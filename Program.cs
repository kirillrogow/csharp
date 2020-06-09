using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace lab3
{

    public class Vehicle
    {
        //поля
        //private int price;

        //конструктор
        public Vehicle(string name, string country)
        {
            if(String.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Error: please enter the name.");
            Name = name;
            
            if(String.IsNullOrWhiteSpace(country))
                throw new ArgumentException("Error: please enter the country");
            Country = country;
        }
        
        //свойства
        public string Name { get; }
        public string Country { get; }

        
        
       /* public int Prices //релиз на будущее
        {
            get { return Price; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Error: enter more value");
                Price = value;
            }
        }*/
        

        
        
    }
    
    //наследование
    public sealed class Cars : Vehicle
    {
        //статический элем класса
        public static int BestCar = -1; //speed
        
        //поля
        private int speedMax;

        public Cars(string name, string country)
            : base(name, country)
        {
            speedMax = 220;
            if (speedMax > BestCar)
                BestCar = speedMax;
        }
        public Cars(string name, string country, int maxSpeed)
            : base(name, country)
        {
            speedMax = maxSpeed;
            if (BestCar < speedMax)
                BestCar = speedMax;
        }

        //методы
        public void ShowInfo()
        {
            Console.WriteLine($"\nName: {Name}\nCountry: {Country}\nMax Speed: {speedMax} km/h");
        }
        
        
        public void EditSpeed(int value)
        {
            speedMax = value; //прошивка двигателя позволяет изменять максимальную скорость
            if (BestCar < speedMax)
                BestCar = speedMax;

        }

    }
    
    
    class Program
    {
        static void Main1(string[] args)
        {

            Cars first = new Cars("BMW", "Germany");
            first.ShowInfo();
            //Console.WriteLine(Cars.BestCar);
            first.EditSpeed(777);
            first.ShowInfo();

            


        }
    }
}