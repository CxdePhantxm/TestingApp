using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingApp.Classes;

namespace TestingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new Engine(1, "DP103X", 0);
            var car = new Car(engine);
            var test = new Tester(car);

            test.Test();
            Console.ReadKey();
        }
    }
}