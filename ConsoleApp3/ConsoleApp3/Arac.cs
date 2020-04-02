using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public abstract class Arac
    {
        public string AracAdi { get; set; }
        public abstract void YakitTüketimi();
        public virtual void HızOrtalamasi()
        {
            Console.WriteLine("hiz ort yok");
        }

        public void Temizlet()
        {
            Console.WriteLine("araç temizlendi");
        }

    }
}
