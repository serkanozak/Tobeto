﻿using Core.Entities;
using Core.Entities.Concretes;

namespace Entities;

public class Experience : Entity<Guid>
{
    public Guid? UserId { get; set; }
    public string? OrganisationName { get; set; }
    public string? Position { get; set; }
    public string? Sector { get; set; }
    public string? City { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? Description { get; set; }

    public User? User { get; set; }
}
