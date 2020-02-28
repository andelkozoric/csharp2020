using System;

namespace _8_2_2_2_out
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a; // primjer bez vrijednosti
            int b = 88; // primjer sa vrijednosti
            inicijaliziraj(out a);
            Console.WriteLine("a je jednako" + a);

            inicijaliziraj(out b);
            Console.WriteLine("b je jednako" + b);


        }

        private static void inicijaliziraj(out int a)
        {
            a = 55;
        }
    }
}
