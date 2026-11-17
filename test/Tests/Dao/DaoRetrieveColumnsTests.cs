#pragma warning disable SA1210 // Using order varies with project name after template replacement
using Azure.DataverseService.Foundation.Dao;
using Microsoft.Extensions.Logging;
using Microsoft.PowerPlatform.Dataverse.Client;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using SharedContext.Dao;
using System.Linq.Expressions;
using XrmBedrock.SharedContext;
using Task = System.Threading.Tasks.Task;
#pragma warning restore SA1210

namespace Tests.Dao;

public class DaoRetrieveColumnsTests : TestBase
{
    public DaoRetrieveColumnsTests(XrmMockupFixture fixture)
        : base(fixture)
    {
    }

    [Fact]
    public void StringOfResolvesAttributeLogicalNames()
    {
        Expression<Func<Account, object>> id = a => a.Id;
        Expression<Func<Account, object>> name = a => a.Name!;
        Expression<Func<Account, EntityReference>> primaryContact = a => a.PrimaryContactId!;

        id.StringOf().Should().Be("accountid");
        name.StringOf().Should().Be("name");
        primaryContact.StringOf().Should().Be("primarycontactid");
    }

    [Fact]
    public void LogicalNameAndEntityReferenceUseEntityLogicalName()
    {
        var id = Guid.NewGuid();

        DataverseStaticExtensions.LogicalName<Account>().Should().Be("account");
        id.ToEntityReference<Account>().LogicalName.Should().Be("account");
    }

    [Fact]
    public async Task RetrieveAsyncReturnsOnlyRequestedColumns()
    {
        var accountId = CreateAccount();

        var account = await AdminDao.RetrieveAsync<Account>(accountId, a => a.Name);

        account.Name.Should().Be("Contoso");
        account.Attributes.Should().NotContainKey("accountnumber");
    }

    [Fact]
    public async Task RetrieveAsyncAcceptsIdColumn()
    {
        var accountId = CreateAccount();

        var account = await AdminDao.RetrieveAsync<Account>(accountId, a => a.Id, a => a.Name);

        account.Id.Should().Be(accountId);
        account.Name.Should().Be("Contoso");
        account.Attributes.Should().NotContainKey("accountnumber");
    }

    [Fact]
    public void RetrieveReturnsOnlyRequestedColumns()
    {
        var accountId = CreateAccount();

        var account = AdminDao.Retrieve<Account>(accountId, a => a.Id, a => a.Name!);

        account.Id.Should().Be(accountId);
        account.Name.Should().Be("Contoso");
        account.Attributes.Should().NotContainKey("accountnumber");
    }

    [Fact]
    public void RetrieveSendsRequestedColumnsToDataverse()
    {
        var accountId = Guid.NewGuid();
        var service = Substitute.For<IOrganizationService>();
        service.Retrieve(Arg.Any<string>(), Arg.Any<Guid>(), Arg.Any<ColumnSet>())
            .Returns(new Entity(Account.EntityLogicalName, accountId));
        var dao = new DataverseAccessObject(service, Substitute.For<ILogger>());

        dao.Retrieve<Account>(accountId, a => a.Id, a => a.Name!);

        service.Received(1).Retrieve(
            Account.EntityLogicalName,
            accountId,
            Arg.Is<ColumnSet>(c => !c.AllColumns && c.Columns.Count == 2 && c.Columns[0] == "accountid" && c.Columns[1] == "name"));
    }

    [Fact]
    public void DeleteUsesEntityLogicalName()
    {
        var accountId = Guid.NewGuid();
        var service = Substitute.For<IOrganizationService>();
        var dao = new DataverseAccessObject(service, Substitute.For<ILogger>());

        dao.Delete<Account>(accountId);

        service.Received(1).Delete(Account.EntityLogicalName, accountId);
    }

    [Fact]
    public async Task RetrieveCachableAsyncCachesPerColumnSet()
    {
        var accountId = CreateAccount();
        var cacheKey = $"account-{Guid.NewGuid()}";

        var withName = await AdminDao.RetrieveCachableAsync<Account>(cacheKey, accountId, a => a.Name);
        var withNumber = await AdminDao.RetrieveCachableAsync<Account>(cacheKey, accountId, a => a.AccountNumber);

        withName!.Name.Should().Be("Contoso");
        withNumber!.AccountNumber.Should().Be("A-100");
        withNumber.Attributes.Should().NotContainKey("name");
    }

    [Fact]
    public async Task RetrieveWithCtAsyncUsesInstanceTokenAndColumnsWhenTokenIsDefault()
    {
        var accountId = Guid.NewGuid();
        var service = Substitute.For<IOrganizationServiceAsync2>();
        service.RetrieveAsync(Arg.Any<string>(), Arg.Any<Guid>(), Arg.Any<ColumnSet>(), Arg.Any<CancellationToken>())
            .Returns(new Entity(Account.EntityLogicalName, accountId));
        using var cancellationTokenSource = new CancellationTokenSource();
        var dao = new DataverseAccessObjectAsync(service, Substitute.For<ILogger>());
        dao.SetCancellationToken(cancellationTokenSource.Token);

        await dao.RetrieveWithCtAsync<Account>(accountId, default, a => a.Id, a => a.Name);

        await service.Received(1).RetrieveAsync(
            Account.EntityLogicalName,
            accountId,
            Arg.Is<ColumnSet>(c => !c.AllColumns && c.Columns.Count == 2 && c.Columns[0] == "accountid" && c.Columns[1] == "name"),
            cancellationTokenSource.Token);
    }

    private Guid CreateAccount() =>
        AdminDao.Create(new Account
        {
            Name = "Contoso",
            AccountNumber = "A-100",
        });
}
