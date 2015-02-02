using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AOOADAssignment
{
    interface Observer : IObserver<Event>
    {
        void update(string status);
    }
}
