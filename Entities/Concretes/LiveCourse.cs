﻿using Core.Entities;

namespace Entities;

public class LiveCourse : Entity<Guid>
{
    public Guid? CourseId { get; set;}
    public Guid? CourseDetailId { get; set; }

    public Course? Course { get; set; }
    public List<LiveContent>? LiveContents { get; set; }
    public CourseDetail? CourseDetail { get; set; }
}
