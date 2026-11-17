#pragma warning disable SA1210 // Using order varies with project name after template replacement
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using SharedContext.Dao;
using XrmBedrock.SharedContext;
using Task = System.Threading.Tasks.Task;
#pragma warning restore SA1210

namespace Tests.Dao;

public class DaoAliasedValueTests : TestBase
{
    public DaoAliasedValueTests(XrmMockupFixture fixture)
        : base(fixture)
    {
    }

    [Fact]
    public void RelatedEntityBuildsTypedEntityFromAlias()
    {
        var contactId = Guid.NewGuid();
        var source = new Entity(Account.EntityLogicalName, Guid.NewGuid());
        source["name"] = "Contoso";
        source["pc.contactid"] = new AliasedValue(Contact.EntityLogicalName, "contactid", contactId);
        source["pc.firstname"] = new AliasedValue(Contact.EntityLogicalName, "firstname", "Jane");
        source["other.firstname"] = new AliasedValue(Contact.EntityLogicalName, "firstname", "John");
        source.FormattedValues["pc.gendercode"] = "Female";

        var contact = source.RelatedEntity<Contact>("pc");

        contact.Should().NotBeNull();
        contact!.LogicalName.Should().Be(Contact.EntityLogicalName);
        contact.Id.Should().Be(contactId);
        contact.FirstName.Should().Be("Jane");
        contact.Attributes.Should().NotContainKey("name");
        contact.FormattedValues["gendercode"].Should().Be("Female");
    }

    [Fact]
    public void RelatedEntityUsesPrimaryKeyOfActivities()
    {
        var activityId = Guid.NewGuid();
        var source = new Entity(Account.EntityLogicalName, Guid.NewGuid());
        source["t.activityid"] = new AliasedValue(XrmBedrock.SharedContext.Task.EntityLogicalName, "activityid", activityId);

        var task = source.RelatedEntity<XrmBedrock.SharedContext.Task>("t");

        task!.Id.Should().Be(activityId);
    }

    [Fact]
    public void RelatedEntityReturnsNullForUnknownAlias()
    {
        var source = new Entity(Account.EntityLogicalName, Guid.NewGuid());
        source["pc.firstname"] = new AliasedValue(Contact.EntityLogicalName, "firstname", "Jane");

        source.RelatedEntity<Contact>("missing").Should().BeNull();
    }

    [Fact]
    public async Task RelatedEntityReadsLinkEntityFromQuery()
    {
        var contact = Producer.SampleProduceValidContact(new Contact { FirstName = "Jane" });
        var accountId = AdminDao.Create(new Account { Name = "Contoso", PrimaryContactId = contact.ToEntityReference() });
        var query = new QueryExpression(Account.EntityLogicalName) { ColumnSet = new ColumnSet("name") };
        query.Criteria.AddCondition("accountid", ConditionOperator.Equal, accountId);
        var link = query.AddLink(Contact.EntityLogicalName, "primarycontactid", "contactid");
        link.EntityAlias = "pc";
        link.Columns = new ColumnSet("contactid", "firstname");

        var accounts = await AdminDao.RetrieveListAsync<Account>(query);
        var related = accounts.Single().RelatedEntity<Contact>("pc");

        related!.Id.Should().Be(contact.Id);
        related.FirstName.Should().Be("Jane");
    }
}
