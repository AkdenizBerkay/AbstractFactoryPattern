using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Elements
{
    public class TavukMenu : Menu
    {
        public override decimal KacCesit()
        {
            return 5;
        }

        public override decimal MenuPuani()
        {
            return 4;
        }
    }
}
