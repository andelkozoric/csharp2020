using System;
using System.IO;

namespace _10._1._2_3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program zapisuje u datoteku");
            Console.WriteLine("1) 3or7uNoviRed.txt");
            Console.WriteLine("2) 3or7SaZarezima.txt");
            Console.WriteLine("sve brojeve od 10 do 100 djeljive sa 3 ili 7.");
            Console.WriteLine("Presss any button to continue..");
            Console.ReadKey();

            FileStream fs1 = new FileStream("3or7uNoviRed.txt", FileMode.Create);
            StreamWriter sw1 = new StreamWriter(fs1);
            FileStream fs2 = new FileStream("3or7SaZarezima.txt", FileMode.Create);
            StreamWriter sw2 = new StreamWriter(fs2);

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 || i % 7 == 0)
                {
                    sw1.WriteLine(i);
                    sw2.Write("{0}, ", i);
                }
            }

            sw1.Flush();
            sw1.Close();
            fs1.Close();
            sw2.Flush();
            sw2.Close();
            fs2.Close();

            Console.WriteLine("Zelie li ispisati sadrzaj datoteke (D/N) ?");
            char odgovor = Console.ReadKey().KeyChar;

            if (odgovor == 'D' || odgovor == 'd')
            {
                fs1 = new FileStream("3or7uNoviRed.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs1);
                string s = sr.ReadToEnd();
                Console.WriteLine(s);
                sr.Close();
                fs1.Close();

                fs1 = new FileStream("3or7SaZarezima.txt", FileMode.Open);
                sr = new StreamReader(fs1);
                s = sr.ReadToEnd();
                Console.WriteLine(s);
                sr.Close();
                fs1.Close();

                Console.ReadLine();
            }


        }
    }
}
