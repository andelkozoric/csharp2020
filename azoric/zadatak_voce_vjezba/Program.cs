using System;

namespace zadatak_voce_vjezba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Banana b1 = new Banana(20);
            Banana b2 = new Banana(10);
           

            Naranca n1 = new Naranca(25);
            Console.WriteLine(n1);

            Apple a1 = new Apple(30);
            Console.WriteLine(a1);

            Banana[] bananas = new Banana[2];
            Banana[] truleBanane = new Banana[2];
            bananas[0] = b1;
            bananas[1] = b2;

            for (int i = 0; i < bananas.Length; i++)
            {
                Console.WriteLine(bananas[i]);
            }






        }
    }
}
