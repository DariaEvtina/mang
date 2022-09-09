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
        public tegelane[] tegelansed = new tegelane[]{ };
        public mangu( int arvu, List<Ese> esemed)
        {
            Random rnd=new Random();
            for (int i = 0; i < arvu; i++)
            {
                tegelane tegelane_ = new tegelane($"{i}-tegelane");
                for (int e = 0; e < rnd.Next(0,5); i++)
                {
                    tegelane_.lisaEse(esemed[rnd.Next(2, 10)].info(), esemed[rnd.Next(2, 10)].punktideArv());
                }
                tegelansed.Append(tegelane_);
            }
            
        }

        public int CompareTo(int other)
        {
            if (other == 0) throw new ArgumentException("Vale parameetri väärtus");
            return other;
        }
        public void suurimaEsemeteArvuga()
        {
            for (int i = 0; i < tegelansed.Length; i++)
            {
                foreach (var item in tegelansed)
                {
                    if (i!= tegelansed.Length)
                    {
                        if (tegelansed[i].eseSum() > tegelansed[i + 1].eseSum())
                        {
                            Console.WriteLine(item.info() + "  " + CompareTo(item.eseSum()));
                        }
                    }
                }
            }
                
        }
        public void suurimaPunktideArvuga()
        {
            for (int i = 0; i < tegelansed.Length; i++)
            {
                foreach (var item in tegelansed)
                {
                    if (i != tegelansed.Length)
                    {
                        if (tegelansed[i].punktideArv() > tegelansed[i + 1].punktideArv())
                        {
                            Console.WriteLine(item.info() + "  " + CompareTo(item.punktideArv()));
                        }
                    }
                }
            }
        }


    }
}
