using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    [Serializable]
    public class Araba
    {
        public string direksiyon { get; set; }
        public string motor { get; set; }
        public string yakit { get; set; }
        public string vites { get; set; }

        public Araba DeepCopy()
        {
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, this);
                ms.Position = 0;

                return (Araba)formatter.Deserialize(ms);
            }
        }

        public Araba ShallowCopy()
        {
            return (Araba)this.MemberwiseClone();
        }
    }
}
