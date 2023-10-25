using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solsysdoga
{
    internal class Bolygok
    {
        public string Nev { get; set; }
        public int HoldSzama { get; set; }
        public double Arany { get; set; }

        public Bolygok(string v)
        {
            string[] adatok = v.Split(';');
            Nev = adatok[0];
            HoldSzama = int.Parse(adatok[1]);
            Arany = double.Parse(adatok[2].Replace('.', ','));
        }
    }
}
