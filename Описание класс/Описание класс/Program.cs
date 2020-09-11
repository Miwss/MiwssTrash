using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.IO;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            var motor = new Motor();//Инициализируем обьект класса
            motor.Model = "YYY";//Задаем параметр для поиска в базе



            Console.WriteLine(Poisk.SearchCarByMotor(motor.Model));

            Console.ReadKey();
        }
    }

    public class Car//инициализация класса
    {
        public string Name { get; set; }//инициализация обьекта класса
        public Motor Motor { get; set; }//ссылка на класс
    }

    public class Motor//инициализация класса
    {
        public string Model { get; set; }//инициализация обьекта класса
        public Car Car { get; set; }//ссылка на класс
    }

    public class Poisk//инициализация класса
    {
        public static string SearchCarByMotor(string motorModel)//ищем по имени мотора
        {
            var baza = new MotorBaza();//создается обьект базы

            foreach (var motor in baza.Motors)//метод перебора базы
            {
                if (motor.Model == motorModel)
                    return motor.Car.Name;
            }

            //return baza.Motors.FirstOrDefault(n => n.Model == motorModel).Car.Name;

            return null;
        }
    }

    public class MotorBaza//инициализация класса
    {
        public List<Motor> Motors = new List<Motor>//Инициализация списка и его заполнение
        {
            new Motor() {Model = "XXX", Car =  new Car()  {Name = "BMW"}},
            new Motor() {Model = "YYY", Car =  new Car()  {Name = "Audi"}},
            new Motor() {Model = "ZZZ", Car =  new Car()  {Name = "Ferrari"}},
            new Motor() {Model = "QQQ", Car =  new Car()  {Name = "Lada"}}
        };
    }

}





