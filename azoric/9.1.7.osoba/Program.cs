using System;
using System.Collections.Generic;
using System.Text;

namespace _9._1._7.osoba
{
    class Program
    {
        static void Main(string[] args)
        {
            //u glavnom programu instanciramo novi objekt klase Covjek
            Covjek covjek = new Covjek();

            //i trazimo unos imena i prezime
            Console.Write("Unesite ime covjeka!");

            covjek.Ime = Console.ReadLine();

            Console.Write("Unesite prezime covjeka!");

            covjek.Prezime = Console.ReadLine();

        }
    }
}
