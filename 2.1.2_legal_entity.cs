using abstr_Human;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace sharp_26_10_2022_class_abstract
{
    internal class legal_entity : buyer// юридическое лицо (организация)
    {
        public string _Organiz;
        public legal_entity(string Name, string Soname, int Age, string Cost_type, string Organiz) :
           base(Name, Soname, Age, Cost_type) //string Name, string Soneme, int Age, string Cost_type, string Adress
        {
            //_Address = "25 Лет октября";
            _Name = Name;
            _Soname = Soname;
            _Age = Age;
            _Cost_type = Cost_type;
            _Organiz = Organiz;
        }
        public override void Print()
        {
            Console.WriteLine("\nИмя: " + _Name + "\nФамилия: " +
                _Soname + "\nВозраст: " + _Age + "\nТип расчета: " + _Cost_type + "\nОрганизация: " + _Organiz + "\n");
        }
    }
}
