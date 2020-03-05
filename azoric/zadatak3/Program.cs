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

            Console.WriteLine("Ime automobila je {1}, proizveden je {2}, osnovna cijena mu je {3}, star je {4}", a1.Naziv, a1.GodinaProizvodnje, a1.OsnovnaCijena);


            //Metode
            a1.Starost();

            
            


            
        }


      
    }
}
