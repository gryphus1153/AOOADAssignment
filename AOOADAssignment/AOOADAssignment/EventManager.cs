using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AOOADAssignment
{
    class EventManager : User
    {
        public EventManager() { }
        public EventManager(string uID, string pass, Name name, string email, Address addr, ArrayList sList, ArrayList eList): base(uID, pass, name, email, addr)
        {
            SpecialititesList = sList;
            EventList = eList;
        }

        public ArrayList SpecialititesList { get; set; }
        public ArrayList EventList { get; set; }
    }
}
