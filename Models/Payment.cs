using System;

namespace CreditCalculator.Models
{
    /// <summary>
    /// Класс для хранения одного платежа в таблице.
    /// </summary>
    public class Payment
    {
        /// <summary>
        /// Номер платежа.
        /// </summary>
        public int Noumber { get; set; }
        /// <summary>
        /// Дата платежа.
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Размер платеда по телу.
        /// </summary>
        public Money SizePayment { get; set; }
        /// <summary>
        /// Размер платежа по проценту.
        /// </summary>
        public double Percent { get; set; }
        /// <summary>
        /// Остаток основного долга.
        /// </summary>
        public Money Renains { get; set; }

        public Payment(int noumber, DateTime date, Money sizePayment, double percent, Money renains)
        {
            Noumber = noumber;
            Date = date;
            SizePayment = sizePayment;
            Percent = percent;
            Renains = renains;
        }
    }


}
