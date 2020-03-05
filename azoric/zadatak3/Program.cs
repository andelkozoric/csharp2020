using System;

namespace zadatak3
{
    class Program
    {
        
        

        static void Main(string[] args)
        {
            

            Automobil a1 = new Automobil();

            Console.WriteLine("Unesite naziv automobila");
            a1.Naziv = Console.ReadLine();

            Console.WriteLine("Unesite godinu proizvodnje");
            a1.GodinaProizvodnje = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite osnovnu cijenu");
            a1.OsnovnaCijena = double.Parse(Console.ReadLine());

            Console.WriteLine($"Automobil je {a1.Naziv}, godina proizvodnje je {a1.GodinaProizvodnje}, cijena je {a1.OsnovnaCijena}");


            //Metode
            a1.Starost();

            
            


            
        }


      
    }
}
