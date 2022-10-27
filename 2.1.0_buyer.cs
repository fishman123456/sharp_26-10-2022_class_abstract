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
            Console.WriteLine("\tИмя: " + _Name + "\nФамилия: " +
                _Soname + "\nВозраст: " + _Age + "\n Тип расчета:" + 
                _Cost_type + "\n");
        }
    }
}
