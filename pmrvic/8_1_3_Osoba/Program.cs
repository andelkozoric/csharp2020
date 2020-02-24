using System;

namespace _8_1_3_Osoba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ovo su osobe");
            Osoba o1 = new Osoba();

            Console.WriteLine("Molim unesite ime osobe:");
            o1.Ime = Console.ReadLine();

            Console.WriteLine("Molim unesite prezime osobe:");
            o1.Prezime = Console.ReadLine();

            Console.WriteLine($"Dobrodošli {o1}");

            Console.WriteLine("Molim unesite datum rođenja:");

<<<<<<< HEAD
            o1.Datrod= Console.ReadLine();
=======
            o1.Datrod = Console.ReadLine();
>>>>>>> c606924283b27a469339b2353a50582715f63607
            o1.IspisBrojGodina();



        }
    }
}
