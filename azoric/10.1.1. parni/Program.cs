using System;
using System.IO;


namespace _10._1._1._parni
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Parni brojevi od 1 do 100");
            FileStream datoteka = new FileStream("PARNI.txt", FileMode.Create);

            StreamWriter pisac = new StreamWriter(datoteka);

            for (int i = 1; i <= 100; i++)
                if (i % 2 == 0) 
                {
                    pisac.WriteLine(i);
                    
                }
            pisac.Flush();
            pisac.Close();
            datoteka.Close();

            
        }
    }
}
