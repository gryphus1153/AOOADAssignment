using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADAssignment
{
    class CreditCard
    {
        public CreditCard() { }
        public CreditCard(string ccNo, string expDate)
        {
            CreditCardNo = ccNo;
            ExpiryDate = expDate;
        }

        public string CreditCardNo { get; set; }
        public string ExpiryDate { get; set; }
    }
}
