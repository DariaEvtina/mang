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
        public List<tegelane> tegelansed;
        public mangu( int arvu, List<Ese> esemed)
        {
            tegelansed = new List<tegelane> { };
            Random rnd=new Random();
            for (int i = 0; i <= arvu; i++)
            {
                tegelane tegelane_ = new tegelane($"{i}-tegelane");
                
                for (int e = 0; e < rnd.Next(0,5); e++)
                {
                    tegelane_.lisaEse(esemed[rnd.Next(1, 9)].info(), esemed[rnd.Next(2, 9)].punktideArv());
                }
                tegelansed.Add(tegelane_);
                //Console.WriteLine(tegelansed[i].info()) ;
            }
            
        }

        public int CompareTo(int other)
        {
            if (other == 0) throw new ArgumentException("Vale parameetri väärtus");
            return other;
        }
        public void suurimaEsemeteArvuga()
        {
            for (int i = 0; i < tegelansed.Count; i++)
            {
                foreach (var item in tegelansed)
                {
                    if (i!= tegelansed.Count)
                    {
                        if (tegelansed[i].eseKokkuvote() > tegelansed[i + 1].eseKokkuvote())
                        {
                            Console.WriteLine(item.info() + "  " + CompareTo(item.eseKokkuvote()));
                        }
                    }
                }
            }
                
        }
        public void suurimaPunktideArvuga()
        {
            for (int i = 0; i < tegelansed.Count; i++)
            {
                foreach (var item in tegelansed)
                {
                    if (i != tegelansed.Count)
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
