﻿// See https://aka.ms/new-console-template for more information
// создать абстрактный класс Человек (имя фамилия возраст)
// создать метод Print. на его основе классы:
// абстрактных покупатель (тип расчета)
// абстрактный сотрудник ( адрес работы, зарплата)
// наследуемый директор (адрес кабинета)
// на основе класса покупатель создать:
// частное лицо (адрес доставки)
// юридическое лицо (организация)
// на основе класса сотрудник создать:
// менеджер (отдел работы)
// работник склада (отдел за который ответственнен)
// водитель (автомобиль, номер ТС)
// Для всех классов создать конструкторы и метод Print работающий с base 
using abstr_Human;
using System;
using static System.Console;
class program
{
    void Main()
    {
        private_p F = new private_p("1","2",3,"4","5");
        F.Print();
        
    }
}
