﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inlämningsuppgift1_EmilJ.Models
{
    public class Organizer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone_number { get; set; }
        public List<Event> Events { get; set; }
    }
}
