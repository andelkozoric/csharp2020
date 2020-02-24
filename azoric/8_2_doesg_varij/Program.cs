using System;

namespace _8_2_doesg_varij
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("static klasa - DOSEG varijabli");

            Console.WriteLine("Suma 7.8 + 15.8 je: "+MojStatic.Zbroj(broj1:7.8,broj2:15.8));

            Console.WriteLine("Kub 3.0 je: " + MojStatic.Kub(broj1: 3.0));

            Console.WriteLine("CelzijFahrenheit  je: " + MojStatic.CelzijFahrenheit(broj1:3));



        }

        
    }
}
