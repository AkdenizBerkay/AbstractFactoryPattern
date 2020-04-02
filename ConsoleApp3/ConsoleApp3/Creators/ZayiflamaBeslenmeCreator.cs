using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3.Elements;

namespace ConsoleApp3.Creators
{
    public class ZayiflamaBeslenmeCreator : BeslenmeCreator
    {
        public override Menu MenuCreate()
        {
            return new TavukMenu();
        }

        public override Elements.Program ProgramCreate()
        {
            return new DiyetProgrami();
        }
    }
}
