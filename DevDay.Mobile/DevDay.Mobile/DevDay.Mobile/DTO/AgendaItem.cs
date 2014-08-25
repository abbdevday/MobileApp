using System;
using System.Collections.Generic;
using System.Text;

namespace DevDay.Mobile.DTO
{
    class AgendaItem
    {
        public bool IsTimeslot { get; set; }
        public string Name { get; set; }
        public Session Session { get; set; }

        public bool IsSession
        {
            get { return Session != null; }
        }

        public bool IsNotTimeslot
        {
            get { return !IsTimeslot; }
        }
    }
}
