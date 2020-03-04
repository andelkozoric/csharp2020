using System;

namespace _9._1._1.znak_u_rijeci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite rijec: ");
            // napisite program koji trazi unos jedne rijeci  i unos jednog znaka i zatim ispisuje koliko se puta taj znak pojavljuje u toj rijeci

            string rijec = Console.ReadLine();

            Console.Write("Unesite znak: ");
            char znak = Console.ReadKey().KeyChar;

            int brojPonavljanja = 0;

            //redom ispitujemo svako slovo u recenici
            for (int i = 0; i < rijec.Length; i++)
            {
                //ako je slovo jednako trazenom slovu, imamo slovo vise
                if (rijec[i] == znak)
                {
                    brojPonavljanja++;
                }

            }
            Console.WriteLine();
            Console.WriteLine("Znak {0} pojavljuje se u rijeci {1} {2} puta", znak, rijec, brojPonavljanja);
            Console.ReadKey();
        }
    }
}
