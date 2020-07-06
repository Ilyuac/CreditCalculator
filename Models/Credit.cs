using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreditCalculator.Models
{
    /// <summary>
    /// Клас для хранения всех входных данных о кредите.
    /// </summary>
    public class Credit
    {
        /// <summary>
        /// Сумма кредита.
        /// </summary>
        public int Sum { get; set; }
        /// <summary>
        /// Срок погашения кредита (месяцы днии).
        /// </summary>
        public int Time { get; set; }
        /// <summary>
        /// Ставка по кредиту.
        /// </summary>
        public int Rate { get; set; }
        /// <summary>
        /// Флаг определяющий срок кредита в днях или месяцах.
        /// true - в днях
        /// false - в месяцах
        /// </summary>
        public bool isDayOrMonth { get; set; } = false;
    }
}
