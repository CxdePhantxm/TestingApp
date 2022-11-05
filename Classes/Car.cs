using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp.Classes
{
    public class Car
    {
        //Свойство
        public Engine Engines { get; set; }
        //Конструктор
        public Car(Engine eng)
        {
            Engines = eng;
        }
        //Методы
        public void Test()
        {
            Engines.Start();
        }
    }
}