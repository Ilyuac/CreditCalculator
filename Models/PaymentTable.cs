using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreditCalculator.Models
{
    public class PaymentTable
    {
        private List<Payment> Payments { get; set; }
        public Payment this[int index]
        {
            get { return Payments[index]; }
            set { Payments[index] = value; }
        }
        public Money GetOverpayment { get { return CalculateOverpayment(); } }

        private Money CalculateOverpayment()
        {
            Money overpayment = new Money();



            return overpayment;
        }

    }
}
