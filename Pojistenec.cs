using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektZkouska
{
    class Pojistenec
    {
        public string Jmeno { get; private set; }
        public string Prijmeni { get; private set; }

        public int Vek { get; private set; }
        public ulong TelefonniCislo { get; private set; }

        public Pojistenec(string jmeno, string prijmeni, int vek, ulong telefonniCislo)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
            TelefonniCislo = telefonniCislo;
        }

       

        public override string ToString()
        {
            return Jmeno + "\t" + Prijmeni + "\t" + Vek + "\t" + TelefonniCislo;
        }
    }
}
