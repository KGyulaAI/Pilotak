using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilotak
{
    internal class Pilotak
    {
        string nev;
        string szuletesiDatum;
        string nemzetiseg;
        int rajtszam;

        public Pilotak(string nev, string szuletesiDatum, string nemzetiseg, int rajtszam)
        {
            this.nev = nev;
            this.szuletesiDatum = szuletesiDatum;
            this.nemzetiseg = nemzetiseg;
            this.rajtszam = rajtszam;
        }

        public Pilotak(string nev, string szuletesiDatum, string nemzetiseg)
        {
            this.nev = nev;
            this.szuletesiDatum = szuletesiDatum;
            this.nemzetiseg = nemzetiseg;
        }

        public string Nev { get => nev; }
        public string SzuletesiDatum { get => szuletesiDatum; }
        public string Nemzetiseg { get => nemzetiseg; }
        public int Rajtszam { get => rajtszam; }
    }
}
