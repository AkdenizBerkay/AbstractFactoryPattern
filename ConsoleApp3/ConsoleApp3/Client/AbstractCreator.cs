using ConsoleApp3.Creators;
using ConsoleApp3.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Client
{
    public class AbstractCreator
    {
        private Menu menu;
        private ConsoleApp3.Elements.Program program;
        private BeslenmeCreator bc;
        public AbstractCreator(BeslenmeCreator _bc)
        {
            bc = _bc;
            menu = bc.MenuCreate();
            program = bc.ProgramCreate();
            bc.BeslenmeName = _bc.GetType().Name;
        }

        public void BeslenmeInfo()
        {
            Console.WriteLine(bc.BeslenmeName + ": \n");
            Console.WriteLine(menu.MenuName + ": " + menu.KacCesit() + " çeşit yemek ve " + menu.MenuPuani() + " puanlı");
            Console.WriteLine(program.ProgramName + ": " + program.OgunAdedi() + " öğün yemek ve " + program.KaloriMiktari() + " kalorili");

        }
    }
}
