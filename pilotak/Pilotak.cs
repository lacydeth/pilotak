using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pilotak
{
    internal class Pilotak
    {
        string versenyzoNev;
        string versenyzoSzuletes;
        string versenyzoNemzetiseg;
        int versenyzoRajtszam;

        public Pilotak(string versenyzoNev, string versenyzoSzuletes, string versenyzoNemzetiseg, int versenyzoRajtszam)
        {
            this.versenyzoNev = versenyzoNev;
            this.versenyzoSzuletes = versenyzoSzuletes;
            this.versenyzoNemzetiseg = versenyzoNemzetiseg;
            this.versenyzoRajtszam = versenyzoRajtszam;
        }

        public string VersenyzoNev { get => versenyzoNev; }
        public string VersenyzoSzuletes { get => versenyzoSzuletes; }
        public string VersenyzoNemzetiseg { get => versenyzoNemzetiseg; }
        public int VersenyzoRajtszam { get => versenyzoRajtszam; }
    }
}
