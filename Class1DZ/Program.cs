using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Struct1
{
    class Journal
    {
        public string _name;            //название 
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        DateTime _founding;     // год основания
        public DateTime Founding
        {
            get
            {
                //return _founding != null ? _founding : DateTime.Now;
                if (_founding != null)
                    return _founding;
                return DateTime.MaxValue;
            }
            set
            {
                _founding = value;
            }
        }
        string _description;   //описание
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        string _phone;        //телефон
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        string _email;       //e-mail
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public void Enter()
        {
            WriteLine("Введите название журнала: ");
            _name = ReadLine();
            WriteLine("Введите дату основания журнала:");
            _founding = DateTime.Parse(ReadLine());
            WriteLine("Описание журнала: ");
            _description = ReadLine();
            WriteLine("Ввеите контактный номер телефона: ");
            _phone = ReadLine();
            WriteLine("Почта: ");
            _email = ReadLine();
        }
        public void Print()
        {
            WriteLine($"\nНазвание: {Name}\nГод основания: {Founding}\n" +
                $"Описание: {Description}\nКонтактный телефон: {Phone}" +
                $"\ne-mail: {Email}");
        }
    }
    internal class Struct1
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();
            journal.Enter();
            journal.Print();
            //journal.Phone = "70000";
            //WriteLine(journal.Phone);  

        }
    }
}

