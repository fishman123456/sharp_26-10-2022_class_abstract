using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace abstr_Human
{
    internal class worker : employer// работник склада (отдел за который ответственнен)+

    {
        public string _department;
        public worker(string Name, string Soneme, int Age, string department) : base(Name, Soneme, Age)
        {
            _department = department;
        }
        public override void Print()
        {
            Console.WriteLine("\tИмя: " + _Name + "\nФамилия: " +
                _Soname + "\nВозраст: " + _Age + "\n Отдел работы:" +
                _department + "\n");
        }
    }

