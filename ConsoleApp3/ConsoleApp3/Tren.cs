using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Tren : Arac
    {
        public override void YakitTüketimi()
        {
            Console.WriteLine("Tren cok yakar");
        }

        public override void HızOrtalamasi()
        {
            Console.WriteLine("Tren Yavaş");
        }
    }
}
