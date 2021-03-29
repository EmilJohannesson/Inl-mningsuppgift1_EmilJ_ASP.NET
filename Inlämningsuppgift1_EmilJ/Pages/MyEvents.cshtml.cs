using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Inlämningsuppgift1_EmilJ.Models;

namespace Inlämningsuppgift1_EmilJ.Pages
{
    public class MyEventsModel : PageModel
    {
        private readonly EventsContext _context;

        public MyEventsModel(EventsContext context)
        {
            _context = context;
        }

        public IList<Event> Event { get;set; }

        public async Task OnGetAsync()
        {
            var attendee = await _context.Attendees.Include(e => e.Events).FirstOrDefaultAsync();
            Event = attendee.Events;
        }
    }
}
