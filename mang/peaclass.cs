using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
//
namespace mang
{
    internal class peaclass
    {
        public List<Ese> esemed = new List<Ese> { };
        public void loeEsemed(string filenimi)
        {
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
            loeEsemed(@"..\..\..\esemed.txt");
            mangu mang_ = new mangu(5, esemed);
            var rnd = new Random();
            foreach (var item in mang_.tegelansed)
            {
                Console.WriteLine(item.info());
                var randomized = item.esemete_nimikiri.OrderBy(item => rnd.Next());
                foreach (var value in randomized)
                {
                    Console.WriteLine(value);
                }
                Console.ReadLine();
            }
            
        }
    }
}
