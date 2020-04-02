using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3.Elements;

namespace ConsoleApp3.Creators
{
    public class SporcuBeslenmesiCreator : BeslenmeCreator
    {
        public override Menu MenuCreate()
        {
            return new EtMenu();
        }

        public override Elements.Program ProgramCreate()
        {
            return new NormalProgram();
        }
    }
}
