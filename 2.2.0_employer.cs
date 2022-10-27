namespace abstr_Human
{
    abstract class employer : Human// абстрактный сотрудник ( адрес работы, зарплата)
    {
        public string _Cost_type;

        public employer(string Name, string Soneme, int Age, string Cost_type) : base(Name, Soneme, Age)
        {
            _Cost_type = Cost_type;
        }
        public override void Print()
        {
            Console.WriteLine("\tИмя: " + _Name + "\nФамилия: " +
                _Soname + "\nВозраст: " + _Age + "\n Тип расчета:" +
                _Cost_type + "\n");
        }
    }
}
