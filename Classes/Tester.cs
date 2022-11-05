using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp.Classes
{
    public class Tester
    {
        //Свойство
        public Car Car { get; set; }
        //Конструкторы
        public Tester(Car car)
        {
            Car = car;
        }
        //Методы
        public void Test()
        {
            try
            {
                Car.Test();
            }
            catch (CheckWorkException ex)
            {
                Console.WriteLine($"{ex.Message}" + $"{ex.Name}" + $"{ex.Date}");
            }
        }
    }
}