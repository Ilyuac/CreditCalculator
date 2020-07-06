using System.Collections.Generic;

namespace WebCalculator.Models
{
    public class PaymentTable
    {
        public List<Payment> Payments { get; set; } = new List<Payment>();
        public double GetOverpayment { get; set; }
        public void Add(Payment payment)
        {
            Payments.Add(payment);
        }
    }
}
