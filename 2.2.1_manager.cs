using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstr_Human
{
    internal class manager : employer // менеджер (отдел работы)
    {
        public string _department;
        public manager(string Name, string Soneme, int Age, string Cost_type, string department) :
             base(Name, Soneme, Age, Cost_type)
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


}

