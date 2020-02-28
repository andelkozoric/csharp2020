using System;

namespace _9_1_2_rijec_u_recenici
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string recenica = Console.ReadLine();
            string rijec = Console.ReadLine();
            int brojznakova = 0;

            //Substring (int startIndex);
            //int IndexOf(String value);

            string r = recenica;
            while (r.IndexOf(rijec) != -1)
            {
                brojznakova++;
                r = r.Substring(r.IndexOf(rijec) + 1);
            }
            Console.WriteLine($"Broj rijeci {rijec} u recenici je {brojznakova}");

            //ovaj primjer trazi rijec "je"
            //u recenici "ananas je glup jer je ananas"

            string[] rastavljena_na__niz_stringova = recenica.Split(" ");
            foreach(var item in rastavljena_na__niz_stringova)
            {
                if(item.Equals(rijec)) {
                    brojznakova++;
}
            }
            //ovaj primjer trazi rijec "je"
            //u recenici "ananas je glup jer je ananas"
            //trazimo pomocu replace

            brojznakova = 0;
            int stanjeprije = recenica.Length;
            recenica = recenica.Replace(rijec, "");

            int stanjeposlije = recenica.Length;
            int duljinaTrazeneRijeci = rijec.Length;
            brojznakova = (stanjeprije-stanjeposlije) / duljinaTrazeneRijeci;

            Console.WriteLine($"Broj rijeci {rijec} u recenici je {brojznakova}");




        }
    }
}
