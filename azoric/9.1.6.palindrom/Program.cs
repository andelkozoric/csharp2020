using System;

namespace _9._1._6.palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            // napisite program koji trazi unos jedne linije teksta i zatim ispituje je li taj tekst "palindrom"(pali9ndrom je rijec koja ista čitamo li je s lijeve il desne strane
            Console.WriteLine("Unesite tekst");

            string text = Console.ReadLine();
            text = text.Trim();
            text = text.Replace(" ", "");
            text = text.ToLower();

            string reversedText = "";

            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversedText += text[i];
            }
            Console.WriteLine(reversedText);

            if (text.Equals(reversedText))
            {
                Console.WriteLine(text + " je palindrom!");
            }
            else
            {
                Console.WriteLine(text + " NIJE je palindrom!");
            }


        }
    }
}
