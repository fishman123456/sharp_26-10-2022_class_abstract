using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstr_Human
{
    public abstract class Human
    {
        public string _Name;
        public string _Soname;
        public int _Age;

  
        public Human(string Name, string Soneme, int Age)
        {
            _Name = Name;
            _Soname = Soneme;
            _Age = Age;
        }
        public override string ToString()
        {
            return base.ToString();

        }
        public void Print()
        {
            Console.WriteLine("\tИмя\t" + _Name + "\tФамилия\t" +
                _Soname + "\tВозраст\t" + _Age + "\n");
        }

    }
}
