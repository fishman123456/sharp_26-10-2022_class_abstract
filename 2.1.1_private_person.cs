namespace abstr_Human
{
  class pri_p : buyer //частное лицо (адрес доставки)
    {
        public string _Address;
         public   pri_p (string Name,string Soname, int Age, string Cost_type, string Address): 
            base( Name, Soname, Age, Cost_type) //string Name, string Soneme, int Age, string Cost_type, string Adress
        {
            //_Address = "25 Лет октября";
            _Name = Name;
            _Soname = Soname;   
            _Age = Age;
            _Cost_type = Cost_type;
            _Address = Address;
        }
        public override void Print()
        {
            Console.WriteLine("\nИмя: " + _Name + "\nФамилия: " +
                _Soname + "\nВозраст: " + _Age + "\nТип расчета: " + _Cost_type +"\nАдрес: "+_Address +"\n");
        }
    }
}
