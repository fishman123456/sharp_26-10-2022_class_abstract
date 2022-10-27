using abstr_Human;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstr_Human
{
    internal class private_p : buyer //частное лицо (адрес доставки)
    {
        public string _Address;
        public private_p () //string Name, string Soneme, int Age, string Cost_type, string Adress
        {
            _Address = "25 Лет октября";
        }
        public override void Print()
        {
            Console.WriteLine("\tИмя\t" + _Name + "\tФамилия\t" +
                _Soname + "\tВозраст\t" + _Age + "\t Тип расчета\t" + _Cost_type + "\n");
        }
    }
}
