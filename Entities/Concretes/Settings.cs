using Core.Entities;
using Core.Entities.Concretes;

namespace Entities;

public class Settings : Entity<Guid>
{
    public Guid? UserId { get; set; }

    public User? User { get; set; }
}
