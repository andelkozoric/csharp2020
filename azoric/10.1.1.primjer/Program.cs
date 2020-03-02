using System;
using System.IO;

namespace _10._1._1.primjer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("upisite teksto");
            string upisano = Console.ReadLine();

            //Zapisivanje u datoteku
            FileStream fs1 = new FileStream("Proba.txt", FileMode.Create);

            StreamWriter sw = new StreamWriter(fs1);

            sw.WriteLine(upisano);

            sw.Flush();

            sw.Close();
            fs1.Close();

            //Citanje dadoteke
            FileStream fs2 = new FileStream("proba.txt", FileMode.Open);

            StreamReader sr = new StreamReader(fs2);

            string procitano = sr.ReadToEnd();
            sr.Close();
            fs2.Close();

            Console.WriteLine(procitano);
            Console.ReadKey();
        }
    }
}
