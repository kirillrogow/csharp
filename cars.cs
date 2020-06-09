using System;

namespace CarsConnect
{
    using MainClass;

    //наследование
    public sealed class Cars : Vehicle
    {
        //статический элем класса
        public static int BestCar = -1; //Выведет скорость самой быстрой машины

        //конструктор
        public Cars(string name, string country, int price)
            : base(name, country, price)
        {
            SpeedMax = 220;
            if (SpeedMax > BestCar)
                BestCar = SpeedMax;
        }

        public Cars(string name, string country, int price, int maxSpeed)
            : base(name, country, price)
        {
            SpeedMax = maxSpeed;
            if (BestCar < SpeedMax)
                BestCar = SpeedMax;
        }

        //методы
        public void ShowInfo()
        {
            Console.WriteLine($"\nName: {Name}\nCountry: {Country}\nPrice: {Price} USD\nMax Speed: {SpeedMax} km/h");
        }


        public override void EditSpeed(int value)
        {
            SpeedMax = value; //прошивка двигателя позволяет изменять максимальную скорость
            if (BestCar < SpeedMax)
                BestCar = SpeedMax;
        }

    }

}