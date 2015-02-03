using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace AOOADAssignment
{
    class Customer : User , Observer
    {
        public Customer() { }
        public Customer(string uID, string pass, Name name, string email, Address addr, string phoneNum, CreditCard cc, ArrayList tickList, ArrayList payList) :base(uID, pass, name, email, addr)
        {
            PhoneNumber = phoneNum;
            CreditCard = cc;
            TicketList = tickList;
            PaymentList = payList;
        }

        public string PhoneNumber { get; set; }
        public CreditCard CreditCard { get; set; }
        public ArrayList TicketList { get; set; }
        public ArrayList PaymentList { get; set; }

        public void update(string status) { Console.WriteLine(status); }
    }
}
