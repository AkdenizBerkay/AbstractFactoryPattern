using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Elements
{
    public abstract class Program
    {
        public string ProgramName = null;

        public Program()
        {
            ProgramName = this.GetType().Name;
                
        }
        public abstract decimal KaloriMiktari();

        public virtual decimal OgunAdedi()
        {
            return 3;
        }
    }
}
