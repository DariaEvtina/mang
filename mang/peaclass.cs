using System;
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
        public static void loeEsemed(string filenimi)
        {
            List<Ese> esemed= new List<Ese> { };
            string line;
            using (StreamReader sr = new StreamReader(new FileStream(filenimi, FileMode.OpenOrCreate)))
            {
                while (sr.ReadLine() == null)
                {
                    if ((line=sr.ReadLine()) != null)
                    {
                        string[] rida = line.Split(';');
                        esemed.Add(new Ese(rida[0], Convert.ToInt32(rida[1])));
                    }
                }
            }
        }
        public peaclass()
        {
            mangu mangi= new mangu();
        }
    }
}
