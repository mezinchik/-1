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
        public static bool IsPeakHour(int hour)
        {
            return (hour >= 12 && hour <= 14) || (hour >= 18 && hour <= 20);
        }
        public static int ReadInt(string prompt, int min, int max)
        {
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out int v) && v >= min && v <= max)
                    return v;
                Console.WriteLine("Ошибка! Повторите ввод.");
            }
        }
        public static double ReadDouble(string prompt, double min)
        {
            while (true)
            {
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), out double v) && v >= min)
                    return v;
                Console.WriteLine("Ошибка! Повторите ввод.");
            }
        }

    }
}
