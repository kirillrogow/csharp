using System;
using System.Collections.Generic;
using CarsConnect;
using AircraftConnect;
using SeashipConnect;
using MainClass;
using TimeClass;

class ProgramMain
{
    static void Main(string[] args)
    {
        //создаём для теста сортировки
        List<Cars> dic = new List<Cars>();
        
        dic.Add(new Cars("Lada", "Russia", 300));
        dic.Add(new Cars("Lada2", "Russia2", 200));
        dic.Add(new Cars("Lada3", "Russia3", 100));
        
        //сортируем по цене и выводим
        dic.Sort();
        Console.WriteLine("Sort by price:");
        foreach (Cars a in dic)
            a.ShowInfo();
        
        //создаём
        Cars cars1 = new Cars("BMW", "Germany", 10000);
        //Cars cars2 = new Cars("Benz", "Belarus", 2222);
        Aircraft air1 = new Aircraft("Boeing", "USA", 80000000, 1000);
        SeaShip sea1 = new SeaShip("Alaska", "USA", 50000000);
        
        //посмотрим инфу, доступную о них
        cars1.ShowInfo();
        air1.ShowInfo();
        sea1.ShowInfo();
        
        //прошьем двигатель и увелими максимальную скорость у машинки
        cars1.EditSpeed(300);
        cars1.SpeedChanged += (object sender, SpeedChangedEventArgs e) => {
            Console.WriteLine($"Новая макс. скорость: {e.NewMaxSpeed}");
        };

        //узнаем, какое время суток с делагатом, в качестве аргумента
        //Vehicle.DisplayTime();
        Times.DisplayTime((string str) => {
            Console.WriteLine(str);
        }); 
        
        //сменим время суток на вечер
        Times.ChangeTime(2);
        
        //узнаем за сколько можем продать наш кораблик
        sea1.CallService(3);
        
        //поменяем цену на корабль
        sea1.PriceChanged += (object sender, PriceChangedEventArgs e) => {
            Console.WriteLine($"Новая цена: {e.NewPrice}");
        };
        sea1.ChangePrice(60000000);

        //попробуем теперь узнать за сколько можно продать, но уже в другом сервисе
        sea1.CallService(1);

        // обработка исключения
        try
        {
            new Cars(null, "USA", 10);
        }
        catch (ArgumentNullException e)
        {
            Console.WriteLine($"Обработано исключение 1: {e}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Обработано исключение 2: {e}");
        }

        // обработка другого исключения
        try
        {
            new Cars("Tesla Model S", "USA", -10);
        }
        catch (ArgumentNullException e)
        {
            Console.WriteLine($"Обработано исключение 1: {e}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Обработано исключение 2: {e}");
        }

        /*
         * Остальное можете протестировать сами,
         * я показал всего по немножку.
         */

    }
}