using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace mang
{

    internal class peaclass
    {
        public int Compare(int o1, int o2)
        {
            if (o1 > o2)
            {
                return 1;
            }
            else if (o1 < o2)
            {
                return -1;
            }

            return 0;
        }
        public List<Ese> esemed = new List<Ese> { };
        public void loeEsemed()
        {
            string line;
            using (StreamReader sr = new StreamReader(@"..\..\..\esemed.txt"))
            {
                while (sr.ReadLine() != null)
                {
                    if ((line = sr.ReadLine())!=null)
                    {
                        esemed.Add(new Ese(line.Split(';')[0], Convert.ToInt32(line.Split(';')[1])));
                    }

                }
            }
        }
        public peaclass()
        {
            loeEsemed();
            mangu mang_ = new mangu(5, esemed);
            var rnd = new Random();
            for (int i = 0; i < mang_.tegelansed.Count; i++)
            {
                foreach (tegelane item in mang_.tegelansed)
                {
                    if (i+1!= mang_.tegelansed.Count)
                    {
                        if (mang_.tegelansed[i].esemete_nimikiri.Count> mang_.tegelansed[i+1].esemete_nimikiri.Count)
                        {
                            Console.WriteLine(item.info());
                        }
                    }

                }
            
            }
            
        }
    }
}
