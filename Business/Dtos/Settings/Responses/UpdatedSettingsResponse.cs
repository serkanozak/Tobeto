﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Settings.Responses
{
    public class UpdatedSettingsResponse
    {
        public Guid? Id { get; set; }
        public Guid? UserId { get; set; }
    }
}
