using System;
using System.Collections.Generic;
using System.Text;

namespace Organizer.Models
{
    public class EEventType
    {
        public string Name { get; set; }
        public EventType EType { get; set; }
                
        public enum EventType
        {
            Meeting = 0,
            Showcase = 1,
            PhoneCall = 2,
            Other = 3
        }
        public static EventType Type = EventType.Other;
    }
}
