using ConsoleApp3.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Creators
{
    public abstract class BeslenmeCreator
    {
        public string BeslenmeName = null;

        public BeslenmeCreator()
        {
            BeslenmeName = this.GetType().Name.Split('C')[0].ToString();
        }
        public abstract Menu MenuCreate();
        public abstract ConsoleApp3.Elements.Program ProgramCreate();
    }
}
