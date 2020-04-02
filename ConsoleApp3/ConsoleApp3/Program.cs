using ConsoleApp3.Client;
using ConsoleApp3.Creators;
using ConsoleApp3.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * Abstract Factory Örneği
             * 
             * 
            BeslenmeCreator bc = new SporcuBeslenmesiCreator();

            Menu menu = bc.MenuCreate();
            ConsoleApp3.Elements.Program program = bc.ProgramCreate();

            Console.WriteLine(bc.BeslenmeName + ": \n");
            Console.WriteLine(menu.MenuName + ": " + menu.KacCesit()+ " çeşit yemek ve " + menu.MenuPuani()+ " puanlı");
            Console.WriteLine(program.ProgramName + ": " + program.OgunAdedi() + " öğün yemek ve " + program.KaloriMiktari() + " kalorili");
            */

            /*
             * 
             * Gelişmiş Abstract Factory Örneği                                   
             */

            BeslenmeCreator bc = new SporcuBeslenmesiCreator();
            AbstractCreator ac = new AbstractCreator(bc);
            ac.BeslenmeInfo();


            /*
            Araba x = new Araba();
            x.direksiyon = "a1";
            Console.WriteLine(x.direksiyon);
            Araba y = new Araba();
            y = x;
            y.direksiyon = "a2";
            Console.WriteLine("y nin direksiyonu: " + y.direksiyon);
            Console.WriteLine("x nin direksiyonu: " + x.direksiyon);

            x.direksiyon = "a3";

            Console.WriteLine("y nin direksiyonu: " + y.direksiyon);
            Console.ReadLine();
            */

            //Deep ve Shallow Copy Örnekleri//
            /*
            Araba bmv = new Araba();
            bmv.direksiyon = "bmv1";
            bmv.motor = "bmv2";
            bmv.vites = "bmv3";
            bmv.yakit = "bmv4";

            Araba opel = bmv.ShallowCopy();
            Araba audi = bmv.DeepCopy();

            Console.WriteLine("opel nin direksiyonu: " + opel.direksiyon);
            Console.WriteLine("audi nin direksiyonu: " + audi.direksiyon);
       
            Console.WriteLine("****************************");
            opel.direksiyon = "opel1";

            Console.WriteLine("opel nin direksiyonu: " + opel.direksiyon);
            Console.WriteLine("bmv nin direksiyonu: " + bmv.direksiyon);
            Console.WriteLine("audi nin direksiyonu: " + audi.direksiyon);

            Console.WriteLine("****************************");
            audi.direksiyon = "audi1";

            Console.WriteLine("opel nin direksiyonu: " + opel.direksiyon);
            Console.WriteLine("bmv nin direksiyonu: " + bmv.direksiyon);
            Console.WriteLine("audi nin direksiyonu: " + audi.direksiyon);

            Console.WriteLine("****************************");
            bmv.direksiyon = "bmv1";

            Console.WriteLine("opel nin direksiyonu: " + opel.direksiyon);
            Console.WriteLine("bmv nin direksiyonu: " + bmv.direksiyon);
            Console.WriteLine("audi nin direksiyonu: " + audi.direksiyon);

            Console.WriteLine("###############################");
            Araba volvo = bmv;
            volvo.direksiyon = "volvo1";
            Console.WriteLine("opel nin direksiyonu: " + opel.direksiyon);
            Console.WriteLine("bmv nin direksiyonu: " + bmv.direksiyon);
            Console.WriteLine("audi nin direksiyonu: " + audi.direksiyon);
            

            Tren tcdd = new Tren();

            tcdd.HızOrtalamasi();
            tcdd.Temizlet();
            tcdd.YakitTüketimi();
            
             */


            Console.ReadLine();
        }
    }
}
