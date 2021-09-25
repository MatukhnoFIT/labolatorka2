using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    public class Converter
    {
        private double usd = 26.600f;
        private double eur = 31.100f;
        private double rub = 0.340f;


        public double count;


        public void usdtouahConv()
        {
            Console.WriteLine($"UAH: {this.count * this.usd}");
        }

        public void eurtouahConv()
        {
            Console.WriteLine($"UAH: {this.count * this.eur}");
        }

        public void rubtouahConv()
        {
            Console.WriteLine($"UAH: {this.count * this.rub}");
        }

        public void uahtousdConv()
        {
            Console.WriteLine($"USD: {this.count / this.usd}");
        }

        public void uahtoeurConv()
        {
            Console.WriteLine($"EUR: {this.count / this.eur}");
        }

        public void uahtorubConv()
        {
            Console.WriteLine($"RUB: {this.count / this.rub}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter();
            Console.Write("You can transfer from UAH in USD,EUR,RUB; or from USD,EUR,RUB in UAH\n Choose valute(1-USD, 2-EUR, 3-RUB, 4-UAH)");
            int from = Int32.Parse(Console.ReadLine());
            Console.Write("In what valute?(1-USD, 2-EUR, 3-RUB, 4-UAH)");
            int to = Int32.Parse(Console.ReadLine());
            Console.Write("Type count: ");
            converter.count = Convert.ToDouble(Console.ReadLine());

            if (from == 1 & to == 4)
            {
                converter.usdtouahConv();
            }
            else if (from == 2 & to == 4)
            {
                converter.eurtouahConv();
            }
            else if (from == 3 & to == 4)
            {
                converter.rubtouahConv();
            }
            else if (from == 4 & to == 1)
            {
                converter.uahtousdConv();
            }
            else if (from == 4 & to == 2)
            {
                converter.uahtoeurConv();
            }
            else if (from == 4 & to == 3)
            {
                converter.uahtorubConv();
            }
            else
            {
                Console.Write("Ooops, Error ^_^");
            }
            Console.Read();
        }
    }
}
