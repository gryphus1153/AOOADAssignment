using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADAssignment
{
    public class Venue
    {
        public Venue() { }
        public Venue(string VenueName, Address Addr, Array SeatPlan)
        {
            this.venueName = VenueName;
            this.address = Addr;
            this.seatingPlan = SeatPlan;
        }

        public string venueName { get; set; }
        public Array seatingPlan { get; set; }
        public Address address { get; set; }
    }
}
