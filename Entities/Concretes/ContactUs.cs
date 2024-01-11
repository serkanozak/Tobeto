using Core.Entities;

namespace Entities;

public class ContactUs : Entity<Guid>
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Message { get; set; }
}

