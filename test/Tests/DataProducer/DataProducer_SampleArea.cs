using XrmBedrock.SharedContext;

namespace Tests;

/// <summary>
/// This sample shows how to add ProduceValidXXX methods for an area of your solution.
/// Use partial classes to keep each area's producers in a separate file, and adapt this example when adding your own producers.
/// </summary>
public partial class DataProducer
{
    /// <summary>
    /// Creates and saves a contact, supplying defaults only for values that have not been provided.
    /// Pass null to create a contact with defaults, or pass a contact with the values required by your test.
    /// Uses dao so the contact is created in the requested user context; use elevatedDao for related records that require admin permissions.
    /// </summary>
    /// <param name="contact">The contact values to preserve, or null to create a contact with defaults.</param>
    /// <returns>The saved contact with its assigned ID and any missing default values populated.</returns>
    /// <example>
    /// <code>
    /// var contact = Producer.SampleProduceValidContact(null);
    /// var customContact = Producer.SampleProduceValidContact(new Contact { FirstName = "Jane" });
    /// </code>
    /// </example>
    internal Contact SampleProduceValidContact(Contact? contact) =>
        dao.Producer(contact, e =>
        {
            e.EnsureValue(x => x.FirstName, "John");
            e.EnsureValue(x => x.LastName, "Doe");
        });
}
