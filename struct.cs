using System;

namespace Structure
{
    interface IService
    {
        void Sell(int value, int price); //продажа транспортного средства

    }


    //структуры сервисов для продажи транспортного средства
    public struct ServiceMinsk : IService
    {
        //работает утром и вечером
        public void Sell(int value, int price)
        {
            if (value == 0 || value == 2)
            {
                int vehiclePrice = price - price / 10; //10%
                Console.WriteLine($"\nМы готовы купить это транспортное средство прямо сейчас за {vehiclePrice}$");
            }
            else if (value < 0 || value > 3)
            {
                throw new IndexOutOfRangeException("Incorrect value");
            }
            else
            {
                throw new Exception("This service is closed!");
            }
        }
    }

    public struct ServiceGomel : IService
    {
        //работает утром, в обед и вечером
        public void Sell(int value, int price)
        {
            if (value == 0 || value == 1 || value == 2)
            {
                int vehiclePrice = price - price / 5; //20%
                Console.WriteLine($"\nМы готовы купить это транспортное средство прямо сейчас за {vehiclePrice}$");
            }
            else if (value < 0 || value > 3)
            {
                throw new IndexOutOfRangeException("Incorrect value");
            }
            else
            {
                throw new Exception("This service is closed!");
            }
        }
    }

    public struct ServiceBrest : IService
        {
            //круглосуточно
            public void Sell(int value, int price)
            {
                if (value < 0 || value > 3)
                {
                    throw new IndexOutOfRangeException("Incorrect value");
                }
                else
                {
                    int vehiclePrice = price - price / 4; //25%
                    Console.WriteLine($"\nМы готовы купить это транспортное средство прямо сейчас за {vehiclePrice}$");
                }
            }
        }

    }
