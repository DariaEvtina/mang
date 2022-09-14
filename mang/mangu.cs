using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace mang
{
    internal class mangu 
    {

        List <string> nimi=new List<string> { "Liam, Hort","Henry, Chatman","daria, evtia","Homer, Human","Liam, Hort","Charlotte, Bon","Elijah, Jonns","Henry, Chatman","Test, Test"};
        /*public void loeNimid()
        {
            using (StreamReader sr = new StreamReader(@"..\..\..\nimid.txt"))
            {
                while (sr.ReadLine() != "!")
                {

                            nimi.Add(sr.ReadLine());
                            Console.WriteLine(sr.ReadLine());

                        
                }

                sr.Close();
            }
        }*/
        public void lisaNimid()
        {
            Console.WriteLine("lisa eesnimi:");
            string eesnimi=Console.ReadLine();
            Console.WriteLine("lisa perenimi:");
            string perenimi = Console.ReadLine();
            using (StreamWriter sw = new StreamWriter(@"..\..\..\nimid.txt"))
            {
                foreach (var nimid in nimi)
                {
                    sw.WriteLine(nimid);
                }
                sw.WriteLine(eesnimi+", "+perenimi);
                sw.WriteLine("!");
                sw.Close();
            }
        }
        public List<tegelane> tegelansed=new List<tegelane>();
        public mangu( int arvu, List<Ese> esemed)
        {
            //loeNimid();
            Random rnd=new Random();
            for (int i = 0; i <= arvu; i++)
            {
                tegelane tegelane_ = new tegelane($"{nimi[rnd.Next(0, nimi.Count)]}");
                
                for (int e = 0; e < rnd.Next(1,5); e++)
                {
                    tegelane_.lisaEse(esemed[rnd.Next(0, esemed.Count)].info(), esemed[rnd.Next(1, esemed.Count)].punktideArv());
                }
                tegelansed.Add(tegelane_);
                //Console.WriteLine(tegelansed[i].info()) ;
            }
            
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
                    else if (tegelansed.Count==1)
                    {
                        Console.WriteLine(item.ainultnimi() + " " + item.eseKokkuvote());
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
                    if (i + 1 != tegelansed.Count)
                    {
                        if (tegelansed[i].punktideArv() > tegelansed[i + 1].punktideArv())
                        {
                            Console.WriteLine(item.ainultnimi() + " " + item.punktideArv());
                        }
                    }
                    else if (tegelansed.Count == 1)
                    {
                        Console.WriteLine(item.ainultnimi() + " " + item.punktideArv());
                    }
                }
            }
        }


    }
}
