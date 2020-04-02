using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Elements
{
    public abstract class Menu
    {
        public Menu()
        {
            MenuName = this.GetType().Name;  
        }

        public string MenuName = null;

        public abstract decimal KacCesit();

        public virtual decimal MenuPuani()
        {
            return 5;
        }

    }
}
