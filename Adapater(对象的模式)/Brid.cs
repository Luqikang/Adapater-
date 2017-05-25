using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapater_对象的模式_
{
    public class Brid : Animal
    {
        private string type = "Brid";
        public override void ShowType()
        {
            Console.WriteLine("Type is {0}", type);
        }

        private string color;

        public string Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }
    }
}
