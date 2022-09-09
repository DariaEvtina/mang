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
        public List<tegelane> tegelansed = new List<tegelane>() { };
        public mangu()
        {
            tegelane pea_tegelane = new tegelane("peategenale");
            pea_tegelane.lisaEse("Tavaline haldjarüü", 50);
            pea_tegelane.lisaEse("Võlukeep", 1000);
            tegelansed.Add(pea_tegelane);
            tegelane teine_tegelane = new tegelane("teinetegenale");
            teine_tegelane.lisaEse("Tavaline haldjarüü", 50);
            tegelansed.Add(teine_tegelane);
            tegelane kolme_tegelane = new tegelane("kolmetegenale");
            kolme_tegelane.lisaEse("Väikeste haavade ravi jook", 200); 
            kolme_tegelane.lisaEse("Väga suure osavuse kindad", 600);
            kolme_tegelane.lisaEse("Külmavastane ripats", 400);
            tegelansed.Add(kolme_tegelane);
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
