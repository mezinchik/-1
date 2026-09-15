using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Мезенцева_Лаба_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double orderCost = Class1.ReadDouble("Введите стоимость заказа (руб.): ", 0);
            double distance = Class1.ReadDouble("Введите расстояние доставки (км): ", 0);
            int hour = Class1.ReadInt("Введите время заказа (час): ", 0, 23);

            double delivery = Class1.CalcDelivery(orderCost, distance, hour);
            double total = orderCost + delivery;
        }
    }
}
