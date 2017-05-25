using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapater_对象的模式_
{
  public  class Chicken:Brid
    {
        private string type = "Chicken";
        public override void ShowType()
        {
            Console.WriteLine("Type is {0}", type);
        }
        public void ShowColor()
        {
            Console.WriteLine("Color is {0}", Color);
        }
    }
}
