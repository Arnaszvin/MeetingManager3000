using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMeetingApp.Models
{
    class Meeting
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Person ResponsiblePerson { get; set; }
        public Category Category { get; set;}
        public MeetingType MeetingType { get; set; }
        public DateTime StartDate { get; set;}
        public DateTime EndDate { get; set;}
        public List<Person> People { get; set; }

        public int atendeeCounter = 0;
    }
}
