namespace CCalc.Models
{
    /// <summary>
    /// Клас для хранения всех входных данных о кредите.
    /// </summary>
    public class Credit
    {
        /// <summary>
        /// Сумма кредита.
        /// </summary>
        public double Sum { get; set; }
        /// <summary>
        /// Срок погашения кредита (месяцы днии).
        /// </summary>
        public int Time { get; set; }
        /// <summary>
        /// Флаг определяющий срок кредита в днях или месяцах.
        /// true - в днях
        /// false - в месяцах
        /// </summary>
        public bool isDayOrMonth { get; set; } = false;
        /// <summary>
        /// Ставка по кредиту.
        /// </summary>
        public double Rate { get; set; }
        /// <summary>
        /// Флаг определяющий ставку в днях или год.
        /// true - в днях
        /// false - в год
        /// </summary>
        public bool isDayOrYear { get; set; } = false;

    }
}
