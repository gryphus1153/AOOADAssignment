using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AOOADAssignment
{
    public class Performer
    {
        public Performer() { }
        public Performer(Genre Genre, string PerformerName, ArrayList PerformancesList)
        {
            this.genre = Genre;
            this.performerName = PerformerName;
            this.performanceList = PerformancesList;
        }

        public Genre genre { get; set; }
        public string performerName { get; set; }
        public ArrayList performanceList { get; set; }
    }
}