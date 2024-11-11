﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyTrack.Models
{
    internal class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; } 
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string OrganizedBy { get; set; }

    }
}
