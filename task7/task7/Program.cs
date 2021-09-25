using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    class Employee
    {
        private string _name, _sname;
        private int _exp, _position;
        private double salary, tax;

        public void newEmployee(string name, string sname, int exp, int position)
        {
            this._name = name;
            this._sname = sname;
            this._exp = exp;
            this._position = position;
        }
        public void salaryCalculator()
        {
            salary = 20000 + (500 * _exp * (_position + 1) * 0.7f);
            tax = salary * 0.25f;
        }
        public void writeinf()
        {
            Console.WriteLine($"\nEmployee name: {_name}\nEmployee surname: {_sname}\nPosition: {_exp}\nSalary: {salary}\nTax: {tax}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee empl = new Employee();

            empl.newEmployee("Tymur", "Matukhno", 4, 3);
            empl.salaryCalculator();

            empl.writeinf();
            Console.Read();
        }
    }
}
