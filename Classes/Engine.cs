using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp.Classes
{
    public class Engine
    {
        //Свойства
        public int ID { get; set; }
        public string Name { get; set; }
        public int AmountOfGas { get; set; }
        //Конструктор
        public Engine(int id, string name, int amount)
        {
            ID = id;
            Name = name;
            AmountOfGas = amount;
        }
        //Методы
        public virtual void Start()
        {
            if (AmountOfGas <= 0)
            {
                throw new CheckWorkException("Двигатель не работает!", DateTime.Now, this.Name);
            }
            else
            {
                Console.WriteLine($"Двигатель {Name} заведен!");
            }
        }
    }
}