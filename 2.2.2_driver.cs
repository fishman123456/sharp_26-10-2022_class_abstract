using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstr_Human
{
    class driver : employer      // водитель (автомобиль, номер ТС)
    {
        public string _Car_id;
        public driver(string Name, string Soneme, int Age, string Cost_type, string Car_id) :
             base(Name, Soneme, Age, Cost_type)
        {
            _Car_id = _Car_id;
        }
        public override void Print()
        {
            Console.WriteLine("\tИмя: " + _Name + "\nФамилия: " +
                _Soname + "\nВозраст: " + _Age + "\n Отдел работы:" +
                _Car_id + "\n");
        }
    }
}
