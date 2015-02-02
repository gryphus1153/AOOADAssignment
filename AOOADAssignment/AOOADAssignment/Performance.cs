using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AOOADAssignment
{
    class Performance
    {
        public Performance() { }
        public Performance(string perStart, string evntStart, ArrayList PerformersList)
        {
            this.pStart = perStart;
            this.eStart = evntStart;
            this.performersList = PerformersList;
        }

        public string pStart { get; set; }
        public string eStart { get; set; }
        public ArrayList performersList { get; set; }
    }
}
