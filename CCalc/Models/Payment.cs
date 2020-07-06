namespace CCalc.Models
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
        public string Date { get; set; }
        /// <summary>
        /// Размер платеда по телу.
        /// </summary>
        public double SizePayment { get; set; }
        /// <summary>
        /// Размер платежа по проценту.
        /// </summary>
        public double Percent { get; set; }
        /// <summary>
        /// Остаток основного долга.
        /// </summary>
        public double Renains { get; set; }

        public Payment(int noumber, string date, double sizePayment, double percent, double renains)
        {
            Noumber = noumber;
            Date = date;
            SizePayment = sizePayment;
            Percent = percent;
            Renains = renains;
        }
    }


}
