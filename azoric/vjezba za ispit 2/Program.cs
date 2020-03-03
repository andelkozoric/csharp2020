using System;
using System.Collections;
using System.Collections.Generic;

namespace vjezba_za_ispit_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            

            List<string> A = new List<string>();

            List<string> I = new List<string>();

            List<string> O = new List<string>();

            string t = Console.ReadLine();
            t = t.Trim();
            string[] rijeci = t.Split(" ");

            for(int i = 0; i < rijeci.Length; i++)
            {
                if (rijeci[i].Substring(0, 1) == "A" || rijeci[i].Substring(0, 1) == "a") 
                {
                    A.Add(rijeci[i]);
                }
            }
            Console.WriteLine(A.Count);









        }
    }
}
