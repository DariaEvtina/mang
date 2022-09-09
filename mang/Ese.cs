using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mang
{
    internal class Ese : uksus
    {
        private string nimetus;
        private int punkArv;
        public Ese(string nimetus, int punkArv)
        {
            this.nimetus = nimetus;
            this.punkArv = punkArv;
        }

        public string info()
        {
            return nimetus;
        }

        public int punktideArv()
        {
            return punkArv;
        }
    }
}
