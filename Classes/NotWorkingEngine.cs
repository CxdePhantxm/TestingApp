using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp.Classes
{
    public class NotWorkingEngine: Engine
    {
        public NotWorkingEngine(int id, string name, int amount) : base(id, name, amount)
        {

        }

        public override void Start()
        {
            if (AmountOfGas <= 0)
            {
                throw new CheckWorkException("Двигатель не работает!", DateTime.Now, this.Name);
            }
            else
            {
                base.Start();
            }
        }
    }
}