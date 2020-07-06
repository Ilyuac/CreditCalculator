using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCalculator.Models
{
    public class Collections
    {
        public enum SelectTime
        {
            Месяцев,
            Дней
        }

        public enum SelectRate
        {
            Годовых,
            в_день
        }
        public enum SelectPayment
        {
            ежемесячно,
            каждые_15_дней,
            каждые_10_дней
        }
    }
}
