using Inlämningsuppgift1_EmilJ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inlämningsuppgift1_EmilJ.Data
{
    public static class DbInitializer
    {
        public static void Initialize(EventsContext ctx)
        {
            ctx.Database.EnsureCreated();

            if (ctx.Events.Any())
            {
                return;
            }

            var attendees = new Attendee[]
            {
                new Attendee
                {
                    Name = "Bamse",
                    Email = "Bamse@postlåda.se",
                    Phone_number = "111111111"
                }
            };

            ctx.Attendees.AddRange(attendees);
            ctx.SaveChanges();

            var organizers = new Organizer[]
            {
                new Organizer
                {
                    Name = "Första organizern",
                    Email = "F1@postlåda.se",
                    Phone_number = "0111111"
                },
                new Organizer
                {
                    Name = "Andra organizern",
                    Email = "F2@postlåda.se",
                    Phone_number = "0222222"
                },
                new Organizer
                {
                    Name = "Tredje organizern",
                    Email = "F3@postlåda.se",
                    Phone_number = "0333333"
                }
            };

            ctx.Organizers.AddRange(organizers);
            ctx.SaveChanges();

            var events = new Event[]
            {
                new Event
                {
                    Title = "Första eventet",
                    Organizer = organizers[0],
                    Description = "Det allra första eventet någonsin",
                    Place = "Första parken",
                    Address = "Första parken #1",
                    Date = DateTime.Parse("2021-03-30"),
                    Spots_available = 99
                },
                new Event
                {
                    Title = "Andra eventet",
                    Organizer = organizers[1],
                    Description = "Det andra eventet någonsin",
                    Place = "Första parken",
                    Address = "Första parken #2",
                    Date = DateTime.Parse("2021-03-30"),
                    Spots_available = 100
                },
                new Event
                {
                    Title = "Tredje eventet",
                    Organizer = organizers[2],
                    Description = "Det tredje eventet någonsin",
                    Place = "Första parken",
                    Address = "Första parken #3",
                    Date = DateTime.Parse("2021-03-30"),
                    Spots_available = 101
                }
            };

            ctx.Events.AddRange(events);
            ctx.SaveChanges();


        }
    }
}
