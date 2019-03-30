using System;
using System.Collections.Generic;
/*
1. done 

Создайте структуру Point, которая содержит три координаты.
2. done

    Создать интерфейс IFlyable с методами FlyTo (Point newPoint), WhoAmI (), GetFlyTime ().
3.done
Создайте 3 класса Bird, Plane, SpaceShip, которые реализуют интерфейс IFly.

При реализации метода GetFlyTime () для каждого класса используйте следующее:
- у птицы случайная скорость полета в диапазоне (0-20) км / час
- Самолет развивает скорость +10 км / час каждые 10 км полета, начиная с 200 км / час;
- Космический корабль имеет постоянную скорость 8000 км / с

Получить время полета для 3 объектов этого класса, каждый объект летит из точки (0,0,0) в точку (100, 200, 800)*/
namespace Task5
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            SpaceShip s = new SpaceShip();
            s.WhoAmI();
           // s.GetFlyTime();
          
            //Bird b = new Bird();
            //b.WhoAmI();
            //b.GetFlyTime();
          
        }
    }
}
