using System;
using System.Collections;
using System.Collections.Generic;

namespace zadatak2
{
    class Program
    {
        static void Main(string[] args)
        {
            //napišite broj koji trazi unos rijeci sve dok se ne unese rijec "kraj"
            Console.WriteLine("Hello World!");
            List<string> A = new List<string>();

            List<string> B = new List<string>();

            List<string> C = new List<string>();

            string t = ""; //= Console.ReadLine();

            List<string> rijeci = new List<string>(); 

            while (t != "kraj")
            {
                t = Console.ReadLine();
                
                
            }
           

            for (int i = 0; i < rijeci.Length; i++)
            {
                if (rijeci[i].Substring(0, 1) == "A" || rijeci[i].Substring(0, 1) == "a")
                {
                    A.Add(rijeci[i]);
                }
            }

            for (int i = 0; i < rijeci.Length; i++)
            {
                if (rijeci[i].Substring(0, 1) == "B" || rijeci[i].Substring(0, 1) == "b")
                {
                    B.Add(rijeci[i]);
                }
            }

            for (int i = 0; i < rijeci.Length; i++)
            {
                if (rijeci[i].Substring(0, 1) == "C" || rijeci[i].Substring(0, 1) == "c")
                {
                    C.Add(rijeci[i]);
                }
            }


        }
    }
}
