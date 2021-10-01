using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1) Создать клас предмета
//2) Указать не менее 5 полей данных, описывающих хар-ки класса
//3) Описать метод PrintFields для вывода значений полей данных
//4) Создать метод InitFields для инициализации начальных данных объекта
//5) описать статическое поле count для подсчёта кол-ва объектов
//6) Создать 3 объекта на основе класса и инициализировать их с помощью метода InitFields различными данными
//7) На экран вывести значение полей с помошью метода PrintFields и кол-во созданных объектов

namespace OOP_HomeWorkDop
{
    class Ship
    {
        public string CodeName { get; private set; }
        public string TipeShip { get; private set; }
        public int EnginePower { get; private set; }
        public int GunsCount { get; private set; }
        public int ShipWeight { get; private set; }
        public string WorkShip { get; private set; }

        private static int _count;

        public Ship()
        {
            _count++;

            CodeName = "Аврора";
            TipeShip = "Линкор";
            EnginePower = 0;
            GunsCount = 0;
            ShipWeight = 0;
            WorkShip = "Робит";
        }

        static Ship()
        {
            _count = 0;
        }

        public void InitFields(string codeName, string shipTipe, int enginePower, int gunsCount, int shipWeight, string isShipWork)
        {
            CodeName = codeName;
            TipeShip = shipTipe;
            EnginePower = enginePower;
            GunsCount = gunsCount;
            ShipWeight = shipWeight;
            WorkShip = isShipWork;
        }

        public void PrintFields()
        {
            Console.WriteLine($"CodeName - {CodeName}\nTipe ship - {TipeShip}\nEngin Power - {EnginePower}\nGuns count - {GunsCount}\nShip weight - {ShipWeight} tonns\nThis ship work? - {WorkShip}\nCount ships - {_count}");
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Ship ship = new Ship();
            ship.InitFields("Аврора", "Эсминец", 1500, 23, 600, "На ходу");
            ship.PrintFields();

            Ship ship2 = new Ship();
            ship2.InitFields("Титаник", "Линкор", 2300, 40, 1000, "Не на ходу");
            ship2.PrintFields();

            Ship ship3 = new Ship();
            ship3.InitFields("Непобедимый", "Авианосец", 3000, 35, 900, "На ходу");
            ship3.PrintFields();
            Console.ReadKey();
        }
    }
}
