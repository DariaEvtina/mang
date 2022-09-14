using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace mang
{
    internal class tegelane : uksus 
    {
        private string nimi;
        public List<Ese> esemete_nimikiri=new List<Ese> { };
        public tegelane(string nimi)
        {
            this.nimi = nimi;
        }
        public void lisaEse(string nimetus,int punkArve)
        {
            Ese ese_ = new Ese(nimetus,punkArve);
            esemete_nimikiri.Add(ese_);
        }
        public string info()
        {
            int sum = punktideArv();
                
            return $"Tegelane: {nimi} Esemete: {esemete_nimikiri.Count} Punktide: {sum}";
        }

        public void väljastaEsemed()
        {
            foreach (Ese ese_ in esemete_nimikiri)
            {
                Console.WriteLine( $"Ese: {ese_.info()} Punktide: {ese_.punktideArv()}\n");
            }
        }
        public int eseKokkuvote()
        {
            int sum = 0;
            foreach (Ese ese_ in esemete_nimikiri)
            {
                sum += 1;
            }
            return sum;
        }

        public int punktideArv()
        {
            int sum = 0;
            foreach (Ese ese_ in esemete_nimikiri)
            {
                sum += ese_.punktideArv();
                
            }
            return sum;
        }
    }
}
