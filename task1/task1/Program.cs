using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class Address

    {
        public string country { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public string index { get; set; }
        public string house { get; set; }
        public string apartment { get; set; }

        public void writeAddress()
        {
            Console.WriteLine($"Your address: {street}, house №{house}, apartment: {apartment}, {country}, {city}, {index}");
            Console.Read();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();

            Console.WriteLine("Your country: ");
            address.country = Console.ReadLine();

            Console.WriteLine("Your city: ");
            address.city = Console.ReadLine();

            Console.WriteLine("Your postal index: ");
            address.index = Console.ReadLine();

            Console.WriteLine("Your street name: ");
            address.street = Console.ReadLine();

            Console.WriteLine("Your number of house: ");
            address.house = Console.ReadLine();

            Console.WriteLine("Your number of apartment: ");
            address.apartment = Console.ReadLine();

            address.writeAddress();

        }

    }


}
