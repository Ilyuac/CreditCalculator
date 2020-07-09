using System;
using static WebCalculator.Models.Collections;

namespace WebCalculator.Models
{
    /// <summary>
    /// Клас для хранения всех входных данных о кредите.
    /// </summary>
    public class Credit
    {
        /// <summary>
        /// Сумма кредита.
        /// </summary>
        public double Sum { get; set; } = 0.01;
        /// <summary>
        /// Срок погашения кредита (месяцы днии).
        /// </summary>
        public uint Time { get; set; }
        /// <summary>
        /// Флаг определяющий срок кредита в днях или месяцах.
        /// </summary>
        public SelectTime SelectTime { get; set; }
        /// <summary>
        /// Ставка по кредиту.
        /// </summary>
        public double Rate { get; set; } = 0.01;
        /// <summary>
        /// Флаг определяющий ставку в днях или год.
        /// true - в днях
        /// false - в год
        /// </summary>
        public SelectRate selectRate { get; set; }
        public SelectPayment selectPayment { get; set; }
    }
}
