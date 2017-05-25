using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapater_对象的模式_
{
   public abstract class Animal
    {
        public abstract void ShowType();
        public void Eat()
        {
            Console.WriteLine("Animal always eat.");
        }
    }
}
