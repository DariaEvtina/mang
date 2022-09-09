using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace mang
{
    internal class mangu : IComparable<int>
    {
        public tegelane[] tegelansed = new tegelane[] { };
        public mangu()
        {
            
        }

        public int CompareTo(int other)
        {
            if (other == 0) throw new ArgumentException("Vale parameetri väärtus");
            return other;
        }
        public void suurimaEsemeteArvuga()
        {
                foreach (var item in tegelansed)
                {
                    Console.WriteLine(item.info() + "  " + CompareTo(item.eseSum()));
                }            
        }
        public void suurimaPunktideArvuga()
        {
            foreach (var item in tegelansed)
            {
                Console.WriteLine( item.info()+"  "+CompareTo(item.punktideArv()));
            }
        }


    }
}
