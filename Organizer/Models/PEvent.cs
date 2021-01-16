using System;
using System.Collections.Generic;
using System.Text;

namespace Organizer.Models
{
    public class PEvent
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public TimeSpan Duaration { get; set; }
        public EEventType Type { get; set; }
        public string Comment { get; set; }
    }
}
