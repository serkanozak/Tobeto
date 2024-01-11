using Core.Entities;
using Core.Entities.Concretes;

namespace Entities;

public class Certificate : Entity<Guid>
{
    public Guid? UserId { get; set;}
    public string? FilePath { get; set; }
    public string? FileType { get; set; }
    public DateTime? UploadDate { get; set; }

    public User? User { get; set; }
}

