﻿using System.Xml.Linq;

namespace abstr_Human
{
    internal class director : Human
    {
        string _Add_cab;
        public director (string Name, string Soneme, int Age, string Add_cab) : base(Name, Soneme, Age)
        {
            _Add_cab = Add_cab;
        }
        public override void Print()
        {
            Console.WriteLine("Имя: " + _Name + "\nФамилия: " +
                _Soname + "\nВозраст: " + _Age + "\nНомер кабинета: " +
                _Add_cab + "\n");
        }
    }
}
