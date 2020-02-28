using System;

namespace _9_1_1_znak_u_rijeci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("9_1_1 znak u rijeci, unesi rijeci i jedan znak iz rijeci");
            string rijec = Console.ReadLine();
            string znak = Console.ReadLine();
            int brojznakova = 0;

            //Substring (int startIndex);
            //int IndexOf(String value);

            string r = rijec;
            while (r.IndexOf(znak) != -1)
            {
                brojznakova++;
                r=r.Substring(r.IndexOf(znak)+1);
            }
            Console.WriteLine($"Broj znakova {znak} u recenici je {brojznakova}");

            //drugi nacin
            brojznakova = 0;
            for (int i = 0; i <rijec.Length; i++)
            {
                if(rijec[i] == char.Parse(znak))
                {
                    brojznakova++;
                }
            }
            Console.WriteLine($"Broj znakova {znak} u recenici je {brojznakova}");


        }
    }
}
