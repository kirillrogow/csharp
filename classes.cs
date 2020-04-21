using System;


namespace Connect
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
            speedMax = 220;
            if (speedMax > BestCar)
                BestCar = speedMax;
        }

        public Cars(string name, string country, int price, int maxSpeed)
            : base(name, country, price)
        {
            speedMax = maxSpeed;
            if (BestCar < speedMax)
                BestCar = speedMax;
        }

        //методы
        public void ShowInfo()
        {
            Console.WriteLine($"\nName: {Name}\nCountry: {Country}\nPrice: {price} USD\nMax Speed: {speedMax} km/h");
        }


        public override void EditSpeed(int value)
        {
            speedMax = value; //прошивка двигателя позволяет изменять максимальную скорость
            if (BestCar < speedMax)
                BestCar = speedMax;
        }

    }

    public sealed class Aircraft : Vehicle
    {
        //статический элем класса
        public static int BestAir = -1; //Выведет скорость самой быстрой машины

        //конструктор
        public Aircraft(string name, string country, int price)
            : base(name, country, price)
        {
            speedMax = 400;
            if (speedMax > BestAir)
                BestAir = speedMax;
        }

        public Aircraft(string name, string country, int price, int maxSpeed)
            : base(name, country, price)
        {
            speedMax = maxSpeed;
            if (BestAir < speedMax)
                BestAir = speedMax;
        }

        //методы
        public void ShowInfo()
        {
            Console.WriteLine($"\nName: {Name}\nCountry: {Country}\nPrice: {price} USD\nMax Speed: {speedMax} km/h");
        }


        public override void EditSpeed(int value)
        {
            speedMax = value; //прошивка двигателя позволяет изменять максимальную скорость
            if (BestAir < speedMax)
                BestAir = speedMax;
        }
    
    }
    
    public sealed class SeaShip : Vehicle
    {
        //статический элем класса
        public static int BestSea = -1; //Выведет скорость самой быстрой машины

        //конструктор
        public SeaShip(string name, string country, int price)
            : base(name, country, price)
        {
            speedMax = 60;
            if (speedMax > BestSea)
                BestSea = speedMax;
        }

        public SeaShip(string name, string country, int price, int maxSpeed)
            : base(name, country, price)
        {
            speedMax = maxSpeed;
            if (BestSea < speedMax)
                BestSea = speedMax;
        }

        //методы
        public void ShowInfo()
        {
            Console.WriteLine($"\nName: {Name}\nCountry: {Country}\nPrice: {price} USD\nMax Speed: {speedMax} km/h");
        }


        public override void EditSpeed(int value)
        {
            speedMax = value; //прошивка двигателя позволяет изменять максимальную скорость
            if (BestSea < speedMax)
                BestSea = speedMax;
        }
    
    }

}