﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.LiveCourse.Requests
{
    public class UpdateLiveCourseRequest
    {
        public Guid? Id { get; set;}
        public Guid? CourseId { get; set;}
        public Guid? CourseDetailId { get; set; }
    }
}
