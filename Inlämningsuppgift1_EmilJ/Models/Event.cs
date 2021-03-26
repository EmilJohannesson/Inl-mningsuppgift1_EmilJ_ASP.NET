using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inlämningsuppgift1_EmilJ.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Organizer_id { get; set; }
        public string Description { get; set; }
        public string Place { get; set; }
        public string Address { get; set; }
        public DateTime Date { get; set; }
        public int Spots_available { get; set; }
        public ICollection<Attendee> Attendees { get; set; }
        public ICollection<Organizer> Organizers { get; set; }
    }
}
