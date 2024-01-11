using Core.Entities;

namespace Entities;

public class AnnouncementsNewsCategory : Entity<Guid>
{
    public string? Name { get; set; }
    public List<Announcement>? Announcements { get; set; }
    public List<News>? News { get; set; }
}

