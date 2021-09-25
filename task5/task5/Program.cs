using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    public class User
    {
        private string _login, _name, _sname, _date;
        private int _age;

        string login { get { return _login; } }
        string name { get { return _name; } }
        string sname { get { return _sname; } }
        string date { get { return _date; } }
        int age { get { return _age; } }



        public void profile(string login, string name, string sname, int age, string date)
        {
            this._login = login;
            this._name = name;
            this._sname = sname;
            this._age = age;
            this._date = date;

        }
        public void write()
        {
            Console.WriteLine($"Login: {login}\nName: {name}\nSurname:{sname}\nAge: {age}\nDate: {date}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User users = new User();
            users.profile("Tamerlan", "Tymur", "Matukhno", 18, "25.09.2021");
            users.write();
            Console.Read();
        }
    }
}

