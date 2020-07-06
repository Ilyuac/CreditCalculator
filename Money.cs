using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreditCalculator
{
    public struct Money
    {
        public int SeniorUnit;
        public int JuniorUnit;

        public Money(int seniorUnit, int juniorUnit)
        {
            if (seniorUnit >= 0 && juniorUnit >= 0)
            {
                SeniorUnit = seniorUnit;
                JuniorUnit = juniorUnit;
            }
            else
            {
                SeniorUnit = Math.Abs(seniorUnit);
                JuniorUnit = Math.Abs(juniorUnit);
            }
        }
    }
}
