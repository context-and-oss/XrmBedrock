#pragma warning disable SA1210 // Using order varies with project name after template replacement
using Azure.DataverseService.Foundation.Dao;
using Microsoft.Extensions.Logging;
using Microsoft.PowerPlatform.Dataverse.Client;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using SharedContext.Dao.Exceptions;
using XrmBedrock.SharedContext;
using Task = System.Threading.Tasks.Task;
#pragma warning restore SA1210

namespace Tests.Dao;

public class DaoDoubleWrapTests : TestBase
{
    public DaoDoubleWrapTests(XrmMockupFixture fixture)
        : base(fixture)
    {
    }

    [Fact]
    public async Task RetrieveAsyncMissingRowIsWrappedOnce()
    {
        var accountId = Guid.NewGuid();
        var service = Substitute.For<IOrganizationServiceAsync2>();
        service.RetrieveAsync(Arg.Any<string>(), Arg.Any<Guid>(), Arg.Any<ColumnSet>(), Arg.Any<CancellationToken>())
            .Returns<Entity>(_ => throw new InvalidOperationException("Sequence contains no elements"));
        var dao = new DataverseAccessObjectAsync(service, Substitute.For<ILogger>());

        var act = () => dao.RetrieveAsync<Account>(accountId);

        var exception = (await act.Should().ThrowAsync<DataverseInteractionException>()).Which;
        exception.Message.Should().Be($"There is no account with id {accountId} in Xrm");
        exception.InnerException.Should().BeOfType<InvalidOperationException>();
    }

    [Fact]
    public void RetrieveWithSelectorMissingRowIsWrappedOnce()
    {
        var accountId = Guid.NewGuid();

        var act = () => UserDao.Retrieve<Account, EntityReference>(accountId, a => a.ToEntityReference());

        var exception = act.Should().Throw<DataverseInteractionException>().Which;
        exception.Message.Should().Be($"There is no {typeof(Account)} with id {accountId} in Xrm");
        exception.InnerException.Should().BeOfType<InvalidOperationException>();
    }
}
