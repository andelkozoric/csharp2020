using System;

namespace zadatak1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napišite program koji trazi unos prirodnog broja, a zatim ispisuje taj broj naopako
            Console.WriteLine("Unesite broj");  
            int broj = int.Parse(Console.ReadLine());  //number
            int naopako = 0;  //reverse
            while(broj > 0)  
            {  
                int remainder = broj % 10;   //remainder
                naopako = (naopako * 10) + remainder;  
                broj = broj / 10;  
            }  
            Console.WriteLine("broj naopako {0}",naopako);  
            Console.ReadLine();  

        }
    }
}
