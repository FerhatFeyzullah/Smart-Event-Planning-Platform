﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace SmartEventPlanningSystem.Domain.Entities
{
    public class AppUser:IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public DateOnly BirthDate { get; set; }
        public string Gender { get; set; }
        public string? ProfilePhotoId { get; set; }
        public int Score { get; set; }

        public List<Event> MyEvents { get; set; }
        public List<AppUserCategory> AppUserCategories { get; set; }
    }
}
