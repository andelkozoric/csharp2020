using System;
using System.Collections;
using System.Collections.Generic;

namespace _9._1._4.brojanje_rijeci
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisite program koji trazi unos recenice i zatim broji koliko ima rijeci u toj recenici
            Console.WriteLine("Unesite recenicu!");

            string recenica = Console.ReadLine().Trim();

            int brojRijeci = 0;

            //Ako je nesto upisano, imamo barem jednu rijec
            if (recenica != "")
            {
                brojRijeci++;
            }

            //Redom ispitujemo svako slovo u recenici
            for(int i = 0; i < recenica.Length; i++)
            {
                //Ako je pronaden razmak, znaci da imamo rijeci vise
                if (recenica.Substring(i, 1) == " ")
                {
                    brojRijeci++;
                }
            }

            Console.WriteLine("Broj rijeci u recenici je {0}.", brojRijeci.ToString());
            Console.ReadKey();



            



        }
    }
}
