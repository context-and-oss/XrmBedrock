#pragma warning disable SA1210 // Using order varies with project name after template replacement
using Azure.DataverseService.Foundation.Dao;
using DataverseService.Foundation.Dao;
using Microsoft.Extensions.Logging;
using Microsoft.PowerPlatform.Dataverse.Client;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using SharedContext.Dao;
using SharedContext.Dao.Exceptions;
using XrmBedrock.SharedContext;
using Task = System.Threading.Tasks.Task;
#pragma warning restore SA1210

namespace Tests.Dao;

public class DaoPagingTests : TestBase
{
    private const int SeededRows = 7;

    public DaoPagingTests(XrmMockupFixture fixture)
        : base(fixture)
    {
    }

    [Theory]
    [InlineData(1, 1)]
    [InlineData(5, 5)]
    [InlineData(20, SeededRows)]
    public async Task RetrieveListAsyncLinqTakeReturnsAtMostRequestedRows(int take, int expected)
    {
        var batch = SeedAccounts();

        var accounts = await AdminDao.RetrieveListAsync<Account>(xrm => xrm.AccountSet.Where(a => a.AccountNumber == batch).Take(take));

        accounts.Should().HaveCount(expected);
    }

    // The substitute keeps MoreRecords true, so a second request would show up if TopCount did not stop paging
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    public async Task RetrieveListAsyncLinqTakeSendsOneTopCountRequest(int take)
    {
        var service = Substitute.For<IOrganizationServiceAsync2>();
        service.RetrieveMultipleAsync(Arg.Any<QueryBase>(), Arg.Any<CancellationToken>())
            .Returns(callInfo => Page((QueryBase)callInfo[0]));
        var dao = new DataverseAccessObjectAsync(service, Substitute.For<ILogger>());

        var accounts = await dao.RetrieveListAsync<Account>(xrm => xrm.AccountSet.Take(take));

        accounts.Should().HaveCount(take);
        await service.Received(1).RetrieveMultipleAsync(Arg.Any<QueryBase>(), Arg.Any<CancellationToken>());
        await service.Received(1).RetrieveMultipleAsync(
            Arg.Is<QueryBase>(q => ((QueryExpression)q).TopCount == take && ((QueryExpression)q).PageInfo.Count == 0 && ((QueryExpression)q).PageInfo.PageNumber == 0),
            Arg.Any<CancellationToken>());
    }

    [Fact]
    public Task RetrieveListAsyncLinqSkipThrows()
    {
        var batch = SeedAccounts();

        var act = () => AdminDao.RetrieveListAsync<Account>(xrm => xrm.AccountSet.Where(a => a.AccountNumber == batch).Skip(2).Take(2));

        return act.Should().ThrowAsync<DataverseInteractionException>().WithInnerException(typeof(NotSupportedException));
    }

    [Fact]
    public Task RetrieveListAsyncLinqTakeAboveMaxTopCountThrows()
    {
        var act = () => AdminDao.RetrieveListAsync<Account>(xrm => xrm.AccountSet.Take(5001));

        return act.Should().ThrowAsync<DataverseInteractionException>().WithInnerException(typeof(NotSupportedException));
    }

    [Fact]
    public void ToQueryExpressionMovesTakeToTopCount()
    {
        using var xrm = new Xrm(Substitute.For<IOrganizationService>());

        var withTake = xrm.AccountSet.Where(a => a.Name == "x").Take(5000).ToQueryExpression();
        var withoutTake = xrm.AccountSet.Where(a => a.Name == "x").ToQueryExpression();

        withTake!.TopCount.Should().Be(5000);
        withTake.PageInfo.Count.Should().Be(0);
        withTake.PageInfo.PageNumber.Should().Be(0);
        withoutTake!.TopCount.Should().BeNull();
        withoutTake.PageInfo.Count.Should().Be(0);
    }

    [Fact]
    public void ToQueryExpressionRejectsSkipAndLargeTake()
    {
        using var xrm = new Xrm(Substitute.For<IOrganizationService>());

        var skip = () => xrm.AccountSet.Skip(5).ToQueryExpression();
        var skipTake = () => xrm.AccountSet.Skip(5).Take(5).ToQueryExpression();
        var largeTake = () => xrm.AccountSet.Take(5001).ToQueryExpression();

        skip.Should().Throw<NotSupportedException>().WithMessage("Skip()*");
        skipTake.Should().Throw<NotSupportedException>().WithMessage("Skip()*");
        largeTake.Should().Throw<NotSupportedException>().WithMessage("Take()*");
    }

    // XrmMockup returns MoreRecords = false for every page, so multi page reads use a substitute that pages like Dataverse
    [Fact]
    public async Task RetrieveListAsyncLeavesQueryUnchangedAndCanBeReused()
    {
        var service = Substitute.For<IOrganizationServiceAsync2>();
        service.RetrieveMultipleAsync(Arg.Any<QueryBase>(), Arg.Any<CancellationToken>())
            .Returns(callInfo => Page((QueryBase)callInfo[0]));
        var dao = new DataverseAccessObjectAsync(service, Substitute.For<ILogger>());
        var query = PagedQuery("batch");

        var first = await dao.RetrieveListAsync<Account>(query);
        var second = await dao.RetrieveListAsync<Account>(query);

        first.Should().HaveCount(SeededRows);
        second.Should().HaveCount(SeededRows);
        query.PageInfo.PageNumber.Should().Be(1);
        query.PageInfo.PagingCookie.Should().BeNull();
        await service.DidNotReceive().RetrieveMultipleAsync(query, Arg.Any<CancellationToken>());
    }

    [Fact]
    public void RetrieveListLeavesQueryUnchangedAndCanBeReused()
    {
        var service = Substitute.For<IOrganizationService>();
        service.RetrieveMultiple(Arg.Any<QueryBase>())
            .Returns(callInfo => Page((QueryBase)callInfo[0]));
        var dao = new DataverseAccessObject(service, Substitute.For<ILogger>());
        var query = PagedQuery("batch");

        var first = dao.RetrieveList<Account>(query);
        var second = dao.RetrieveList<Account>(query);

        first.Should().HaveCount(SeededRows);
        second.Should().HaveCount(SeededRows);
        query.PageInfo.PageNumber.Should().Be(1);
        query.PageInfo.PagingCookie.Should().BeNull();
        service.DidNotReceive().RetrieveMultiple(query);
    }

    [Fact]
    public void CopyForPagingCopiesEveryQueryProperty()
    {
        // Fails when the SDK adds a settable QueryExpression property, so CopyForPaging can be updated
        var settable = typeof(QueryExpression).GetProperties()
            .Where(p => p.CanWrite && p.GetSetMethod()?.IsStatic == false)
            .Select(p => p.Name)
            .OrderBy(x => x, StringComparer.Ordinal);
        settable.Should().Equal("ColumnSet", "Criteria", "DataSource", "Distinct", "EntityName", "ExtensionData", "ForceSeek", "NoLock", "PageInfo", "QueryHints", "SubQueryExpression", "TopCount");

        var query = new QueryExpression(Account.EntityLogicalName)
        {
            ColumnSet = new ColumnSet("name"),
            Criteria = new FilterExpression(LogicalOperator.Or),
            DataSource = "archive",
            Distinct = true,
            ForceSeek = "index",
            NoLock = true,
            QueryHints = "hint",
            SubQueryExpression = new QueryExpression("contact"),
            TopCount = 3,
            PageInfo = new PagingInfo { Count = 2, PageNumber = 4, PagingCookie = "cookie", ReturnTotalRecordCount = true },
        };
        query.LinkEntities.Add(new LinkEntity(Account.EntityLogicalName, "contact", "primarycontactid", "contactid", JoinOperator.Inner));
        query.Orders.Add(new OrderExpression("name", OrderType.Descending));

        var copy = PagingProbe.Copy(query);

        copy.Should().NotBeSameAs(query);
        copy.EntityName.Should().Be(query.EntityName);
        copy.ColumnSet.Should().BeSameAs(query.ColumnSet);
        copy.Criteria.Should().BeSameAs(query.Criteria);
        copy.DataSource.Should().Be(query.DataSource);
        copy.Distinct.Should().BeTrue();
        copy.ForceSeek.Should().Be(query.ForceSeek);
        copy.NoLock.Should().BeTrue();
        copy.QueryHints.Should().Be(query.QueryHints);
        copy.SubQueryExpression.Should().BeSameAs(query.SubQueryExpression);
        copy.TopCount.Should().Be(3);
        copy.LinkEntities.Should().Equal(query.LinkEntities);
        copy.Orders.Should().Equal(query.Orders);
        copy.PageInfo.Should().NotBeSameAs(query.PageInfo);
        copy.PageInfo.Should().BeEquivalentTo(query.PageInfo);
    }

    private static EntityCollection Page(QueryBase queryBase)
    {
        var query = (QueryExpression)queryBase;
        var size = query.TopCount ?? (query.PageInfo.Count > 0 ? query.PageInfo.Count : 5000);
        var page = Math.Max(query.PageInfo.PageNumber, 1);
        var first = (page - 1) * size;
        var rows = Enumerable.Range(first, Math.Clamp(SeededRows - first, 0, size))
            .Select(_ => new Entity(Account.EntityLogicalName, Guid.NewGuid()))
            .ToList();
        return new EntityCollection(rows) { MoreRecords = first + size < SeededRows, PagingCookie = $"cookie{page}" };
    }

    private static QueryExpression PagedQuery(string batch)
    {
        var query = new QueryExpression(Account.EntityLogicalName)
        {
            ColumnSet = new ColumnSet("name"),
            PageInfo = new PagingInfo { Count = 2, PageNumber = 1 },
        };
        query.Criteria.AddCondition("accountnumber", ConditionOperator.Equal, batch);
        return query;
    }

    private string SeedAccounts()
    {
        var batch = Guid.NewGuid().ToString("N")[..20];
        for (var i = 0; i < SeededRows; i++)
        {
            AdminDao.Create(new Account { Name = $"Account {i}", AccountNumber = batch });
        }

        return batch;
    }

    private abstract class PagingProbe : DataverseAccessObject
    {
        protected PagingProbe()
            : base(Substitute.For<IOrganizationService>(), Substitute.For<ILogger>())
        {
        }

        public static QueryExpression Copy(QueryExpression query) => CopyForPaging(query);
    }
}
