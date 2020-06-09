using System;
using System.Collections.Generic;
using CarsConnect;
using AircraftConnect;
using SeashipConnect;
using MainClass;

class ProgramMain
{
    static void Main(string[] args)
    {
        //создадим машинку, самолет и морское судно
        List<Cars> dic = new List<Cars>();
        
        dic.Add(new Cars("Lada", "Russia", 300));
        dic.Add(new Cars("Lada2", "Russia2", 200));
        dic.Add(new Cars("Lada3", "Russia3", 100));
        dic.Sort();
        Console.WriteLine("Исходный каталог автомобилей: \n");
        foreach (Cars a in dic)
            a.ShowInfo();
        
        Cars cars1 = new Cars("BMW", "Germany", 10000);
        Cars cars2 = new Cars("Benz", "Belarus", 2222);
        Aircraft air1 = new Aircraft("Boeing", "USA", 80000000, 1000);
        SeaShip sea1 = new SeaShip("Alaska", "USA", 50000000);
        
        //посмотри инфу, доступную о них
        cars1.ShowInfo();
        air1.ShowInfo();
        sea1.ShowInfo();
        
        //прошьем двигатель и увелими максимальную скорость у машинки
        cars1.EditSpeed(300);
       
        //узнаем, какое время суток
        Vehicle.DisplayTime(); 
        
        //сменим время суток на вечер
        Vehicle.ChangeTime(2);
        
        //узнаем за сколько можем продать наш кораблик
        sea1.CallService(3);
        
        //поменяем цену на корабль
        sea1.ChangePrice(60000000);
        
        //попробуем теперь узнать за сколько можно продать, но уже в другом сервисе
        sea1.CallService(1);
        
        /*
         * Остальное можете протестировать сами,
         * я показал всего по немножку.
         */

    }
}