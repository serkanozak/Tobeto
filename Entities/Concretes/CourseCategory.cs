using Core.Entities;

namespace Entities;

public class CourseCategory : Entity<Guid>
{
    public string? Name { get; set; }

    public List<CourseDetail>? CourseDetails { get; set; }
}
