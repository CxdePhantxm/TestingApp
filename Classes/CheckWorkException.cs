using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp.Classes
{
    public class CheckWorkException : Exception
    {
        //Свойства
        public Engine Name { get; set; }
        public DateTime Date { get; set; }
        //Конструкторы
        public CheckWorkException(string message, DateTime now, string name) : base(message)
        { }
    }
}