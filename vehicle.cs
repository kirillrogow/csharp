using System;
using Structure;
using TimeClass;

namespace MainClass
{
    #region Events
    public delegate void PriceChangedEventHandler(object sender, PriceChangedEventArgs e);
    public delegate void SpeedChangedEventHandler(object sender, SpeedChangedEventArgs e);

    public class PriceChangedEventArgs : EventArgs
    {
        public int NewPrice { get; set; }
    }
    public class SpeedChangedEventArgs : EventArgs
    {
        public int NewMaxSpeed { get; set; }
    }
    #endregion
    public class Vehicle : IComparable<Vehicle>
    {
        public event PriceChangedEventHandler PriceChanged;
        public event SpeedChangedEventHandler SpeedChanged;
        //поля
        //protected int price;
        //protected int speedMax;

        //конструктор
        public Vehicle(string name, string country, int price)
        {
            if (String.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name), "Error: please enter the name.");
            Name = name;

            if (String.IsNullOrWhiteSpace(country))
                throw new ArgumentNullException(nameof(country), "Error: please enter the country");
            Country = country;

            if (price <= 0)
                throw new ArgumentException(nameof(price), "Error: enter more value");
            this.Price = price;
        }

        //свойства
        public string Name { get; }
        public string Country { get; }
        public int Price { get; protected set; }
        public int SpeedMax { get; protected set; }

        //методы
        public void ChangePrice(int value)
        {
            Price = value;
            var args = new PriceChangedEventArgs();
            args.NewPrice = value;
            PriceChanged?.Invoke(this, args);
        }


        public virtual void EditSpeed(int value)
        {
            SpeedMax = value; //прошивка двигателя позволяет изменять максимальную скорость
            var args = new SpeedChangedEventArgs();
            args.NewMaxSpeed = value;
            SpeedChanged?.Invoke(this, args);
        }

  
        //методы для обращения в сервис
        public void CallService(int value)
        {
            switch (value)
            {
                case 1:
                    ServiceMinsk attemptOne = new ServiceMinsk();
                    attemptOne.Sell((int)Times.nowTime, Price);
                    break;
                case 2:
                    ServiceGomel attemptTwo = new ServiceGomel();
                    attemptTwo.Sell((int)Times.nowTime, this.Price);
                    break;
                case 3:
                    ServiceBrest attemptThree = new ServiceBrest();
                    attemptThree.Sell((int)Times.nowTime, this.Price);
                    break;
                default: throw new IndexOutOfRangeException("Incorrect value");
            }
        }

        public int CompareTo(Vehicle obj)
        {
            if (this.Price > obj.Price)
                return 1;
            if (this.Price < obj.Price)
                return -1;
            else
                return 0;
        }
    }
}