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
        public List<Ese> esemed = new List<Ese>();
        public void loeEsemed(string filenimi)
        {
            string line;
            using (StreamReader sr = new StreamReader(filenimi))
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
            string filenimi = @"..\..\..\esemed.txt";
            loeEsemed(filenimi);
            mangu mang_ = new mangu(6, esemed);
            foreach (var tegelane in mang_.tegelansed)
            {
                Console.WriteLine(tegelane.info());
                tegelane.väljastaEsemed();
            }
            Console.WriteLine("===========================================ESEMED========================================");
            mang_.suurimaEsemeteArvuga();
            Console.WriteLine("===========================================PUNKTIDE========================================");
            mang_.suurimaPunktideArvuga();
            //mang_.lisaNimid();



        }
    }
}
