using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //тип имя = new Конструктор(параметры);
            Money money = new Money();

            money.SetCountMoney(10);
            money.SetParMoney(200);
            Console.WriteLine("Количество купюр: " + money.GetCountMoney());
            Console.WriteLine("Номинал купюр: " + money.GetParMoney() + "тг.");
            Console.WriteLine("Денег у вас: " + money.valueMoney() + "тг.");
            money.CostProduct(2500);
            money.CountProduct(500);

            Console.Read();
        }
    }
}
