using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AOOADAssignment
{
    class Event : IObservable<Event>
    {
        public Event() { }
        public Event(string eName, DateTime sDate, DateTime eDate, Genre eg, ArrayList pList, int minSeats, string status, EventManager eLead, ArrayList sManagers, bool iConf)
        {
            EventName = eName;
            StartDate = sDate;
            EndDate = eDate;
            EventGenre = eg;
            PerformanceList = pList;
            MinSeats = minSeats;
            Status = status;
            EventLead = eLead;
            SupportManagers = sManagers;
            IsConfirmed = iConf;
        }

        public string EventName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Genre EventGenre { get; set; }
        public ArrayList PerformanceList { get; set; }
        public int MinSeats { get; set; }
        public string Status { get; set; }
        public EventManager EventLead { get; set; }
        public ArrayList SupportManagers { get; set; }
        public bool IsConfirmed { get; set; }

        //update status for display
        public void update(string stats) { this.Status = stats; }
    }
}
