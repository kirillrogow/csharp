using System;

namespace SeashipConnect
{
    using MainClass;
    public sealed class SeaShip : Vehicle
    {
        //статический элем класса
        public static int BestSea = -1; //Выведет скорость самой быстрой машины

        //конструктор
        public SeaShip(string name, string country, int price)
            : base(name, country, price)
        {
            SpeedMax = 60;
            if (SpeedMax > BestSea)
                BestSea = SpeedMax;
        }

        public SeaShip(string name, string country, int price, int maxSpeed)
            : base(name, country, price)
        {
            SpeedMax = maxSpeed;
            if (BestSea < SpeedMax)
                BestSea = SpeedMax;
        }

        //методы
        public void ShowInfo()
        {
            Console.WriteLine($"\nName: {Name}\nCountry: {Country}\nPrice: {Price} USD\nMax Speed: {SpeedMax} km/h");
        }


        public override void EditSpeed(int value)
        {
            SpeedMax = value; //прошивка двигателя позволяет изменять максимальную скорость
            if (BestSea < SpeedMax)
                BestSea = SpeedMax;
        }
    
    }


}