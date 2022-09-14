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
        List <string> nimi=new List<string>() { "Marge", "Homer", "Olivia", "Liam", "Marge", "Charlotte", "Amelia", "Elijah", "Noah", "Henry" };
        public List<tegelane> tegelansed;
        public mangu( int arvu, List<Ese> esemed)
        {
            tegelansed = new List<tegelane> { };
            Random rnd=new Random();
            for (int i = 0; i <= arvu; i++)
            {
                tegelane tegelane_ = new tegelane($"{nimi[rnd.Next(0, 9)]}");
                
                for (int e = 0; e < rnd.Next(1,5); e++)
                {
                    tegelane_.lisaEse(esemed[rnd.Next(0, 9)].info(), esemed[rnd.Next(1, 9)].punktideArv());
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
                    if (i+1 != tegelansed.Count)
                    {
                        if (tegelansed[i].eseKokkuvote() > tegelansed[i + 1].eseKokkuvote())
                        {
                            Console.WriteLine(item.ainultnimi() + " " + item.eseKokkuvote());
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
                    if (i+1 != tegelansed.Count)
                    {
                        if (tegelansed[i].punktideArv() > tegelansed[i + 1].punktideArv())
                        {
                            Console.WriteLine(item.ainultnimi()+" "+item.punktideArv());
                        }
                    }
                }
            }
        }


    }
}
