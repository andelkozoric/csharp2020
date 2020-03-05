using System;
using System.Globalization;

namespace zadatak3
{
    internal class Automobil
    {
        public string Naziv { get; internal set; }
        public int GodinaProizvodnje { get; internal set; }
        public double OsnovnaCijena { get; internal set; }

        public double Starost()
        {
            return (GodinaProizvodnje - 2020);
        }
    }
    }
