using System;

namespace _9._1._22.rijeci.u.recenici
{
    class Program
    {
        static void Main(string[] args)
        {
            //napisite program koji trati unos jedne recenice i jedne rijeci i zatim ispisuje koliko se puta ta rijeci pojavljuje u toj recenici

            Console.WriteLine("Unesite recenicu!");
            string recenica = Console.ReadLine();

            Console.WriteLine("Unesite rijec!");
            string rijec = Console.ReadLine();

            int brojPonavljanja = 0;

            //recenicu pregledavamo slovo po slovo
            for (int i = 0; i <= recenica.Length - rijec.Length; i++)
            {
                //Na svakoj poziciji provjeravamo pojavljuje li se trazena rijec
                //Ako da, brijimo rijec vise
                //Prije usporedivanja sva slova pretvaramo u mala
                if(recenica.Substring(i, rijec.Length).ToLower()== rijec.ToLower())
                {
                    brojPonavljanja++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("rijec \"{0}\" pojavljuje se u recenici \n\"{1}\"\n{2} puta", rijec, recenica, brojPonavljanja);
            Console.ReadKey();


        }
    }
}
