using System;
using System.Collections.Generic;
using System.Text;

namespace _9._1._3.rijeci_u_novi_red
{
    class Program
    {
        static void Main(string[] args)
        {
            //napisite program koji trazi unos recenice i zatim ispisuje svaku rijec iz recenice u novi red
            //ispis rijeci iz recenice
            Console.WriteLine("Unesite recenicu");
            string recenica = Console.ReadLine();

            Console.WriteLine("Unesite rijec");

            //pomocu niza znakova
            string[] rijeci = recenica.Split(' ');
            for (int i = 0; i < rijeci.Length; i++)
            {
                Console.WriteLine(rijeci[i]);
            }

            //pomocu ArrayListe
            System.Collections.ArrayList ar = new System.Collections.ArrayList(recenica.Split(' '));
            foreach (string r in ar)
            {
                Console.WriteLine(r);
            }

            //pomocu substringa
            foreach (char c in recenica)
            {
                if (c != ' ')
                {
                    Console.Write(c);
                }
                else
                {
                    Console.WriteLine();
                }

            }
            Console.ReadKey();

















        }
    }
}
