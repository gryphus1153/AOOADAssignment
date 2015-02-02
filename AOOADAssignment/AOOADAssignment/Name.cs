using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADAssignment
{
    class Name
    {
        public Name(string fName, string mName, string lName)
        {
            FirstName = fName;
            MiddleName = mName;
            LastName = lName;
        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
    }
}
