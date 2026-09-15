using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Мезенцева_Лаба_1
{
    internal class Class1
    {
        public static double CalcDelivery(double orderCost, double distance, int hour)
        {
            if (orderCost >= 2000) return 0;

            double basePrice = 150;
            if (distance > 3)
                basePrice += (distance - 3) * 50;

            if (IsPeakHour(hour))
                basePrice *= 1.3;

            return basePrice;
        }
    }
}
