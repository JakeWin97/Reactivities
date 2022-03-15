using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// All of these properties will form columns inside a table called Activities in db
namespace Domain
{
    // Activity is our first entity
    public class Activity
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string City { get; set; }
        public string Venue { get; set; }
    }
}