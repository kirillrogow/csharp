using System;

namespace AircraftConnect
{
    using MainClass;
    public sealed class Aircraft : Vehicle
    {
        //статический элем класса
        public static int BestAir = -1; //Выведет скорость самой быстрой машины

        //конструктор
        public Aircraft(string name, string country, int price)
            : base(name, country, price)
        {
            SpeedMax = 400;
            if (SpeedMax > BestAir)
                BestAir = SpeedMax;
        }

        public Aircraft(string name, string country, int price, int maxSpeed)
            : base(name, country, price)
        {
            SpeedMax = maxSpeed;
            if (BestAir < SpeedMax)
                BestAir = SpeedMax;
        }

        //методы
        public void ShowInfo()
        {
            Console.WriteLine($"\nName: {Name}\nCountry: {Country}\nPrice: {Price} USD\nMax Speed: {SpeedMax} km/h");
        }


        public override void EditSpeed(int value)
        {
            SpeedMax = value; //прошивка двигателя позволяет изменять максимальную скорость
            if (BestAir < SpeedMax)
                BestAir = SpeedMax;
        }
    
    }


}