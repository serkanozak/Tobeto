﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.AsyncContent.Requests
{
    public class UpdateAsyncContentRequest
    {
        public Guid? AsyncCourseId { get; set; }
        public string? Name { get; set; }
    }
}

