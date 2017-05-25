using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapater_对象的模式_
{
    class Program
    {
        static void Main(string[] args)
        {
            Brid brid = new Chicken();
            Chicken chicken = new Chicken();
            Console.Read();
        }
    }
}
