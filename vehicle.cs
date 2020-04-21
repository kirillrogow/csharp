using System;
using Structure;

namespace MainClass
{

    public class Vehicle
    {
        //поля
        protected int price;
        protected int speedMax;

        //конструктор
        public Vehicle(string name, string country, int price)
        {
            if (String.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Error: please enter the name.");
            Name = name;

            if (String.IsNullOrWhiteSpace(country))
                throw new ArgumentException("Error: please enter the country");
            Country = country;
            
            if (price <= 0)
                throw new ArgumentException("Error: enter more value");
            this.price = price;
        }

        //свойства
        public string Name { get; }
        public string Country { get; }

        //методы
        public void ChangePrice(int value)
        {
            price = value;
        }

        public virtual void EditSpeed(int value)
        {
            speedMax = value; //прошивка двигателя позволяет изменять максимальную скорость
        }
        
        //enum – время суток
        enum Time
        {
            Morning,
            Afternoon,
            Evening,
            Night
        }

        private static Time nowTime = Time.Morning;

        public static void ChangeTime(int time)
        {
            switch (time)
            {
              case 0: nowTime = Time.Morning;
                  break;
              case 1: nowTime = Time.Afternoon;
                  break;
              case 2: nowTime = Time.Evening;
                  break;
              case 3: nowTime = Time.Night;
                  break;
              default: throw new IndexOutOfRangeException("Incorrect value");
            }
            
        }

        public static void DisplayTime()
        {
            Console.WriteLine($"Look.. This is {nowTime}");
        }
        
        //методы для обращения в сервис
        public void CallService(int value)
        {
            switch (value)
            {
             case 1: ServiceMinsk attemptOne = new ServiceMinsk();
                 attemptOne.Sell((int)nowTime, price);
                 break;
             case 2: ServiceGomel attemptTwo = new ServiceGomel();
                 attemptTwo.Sell((int)nowTime, this.price);
                 break;
             case 3: ServiceBrest attemptThree = new ServiceBrest();
                 attemptThree.Sell((int)nowTime, this.price);
                 break;
             default: throw new IndexOutOfRangeException("Incorrect value");
            }
        }

    }
}