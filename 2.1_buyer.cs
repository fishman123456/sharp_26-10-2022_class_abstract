using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstr_Human
{
    abstract class buyer : Human// абстрактных покупатель (тип расчета)

    {
        public string _Cost_type;

        public buyer(string Name, string Soneme, int Age, string Cost_type) : base(Name, Soneme, Age)
        {
            _Cost_type = Cost_type;
        }
        public override void Print()
        {
            Console.WriteLine("\tИмя\t" + _Name + "\tФамилия\t" +
                _Soname + "\tВозраст\t" + _Age + "\t Тип расчета\t" + _Cost_type + "\n");
        }
    }
}
