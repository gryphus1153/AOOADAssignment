using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADAssignment
{
    public class Address
    {

        //default constructor
        public Address() { }
        public Address(string blck, string sName, string uNo, string pCode)
        {
            this.block = blck;
            this.streetName = sName;
            this.unitNo = uNo;
            this.postalCode = pCode;
        }

        //Methods

        //get & set
        public string block { get; set; }
        public string streetName { get; set; }
        public string unitNo { get; set; }
        public string postalCode { get; set; }

    }
}
