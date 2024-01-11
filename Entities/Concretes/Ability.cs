using Core.Entities;
using Core.Entities.Concretes;

namespace Entities;
public class Ability : Entity<Guid>
{
    public Guid? UserId { get; set; }
    public string? Name { get; set; }

    public User? User { get; set; }
}