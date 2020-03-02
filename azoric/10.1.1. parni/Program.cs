using System;
using System.IO;


namespace _10._1._1._parni
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Parni brojevi od 1 do 100");
            FileStream fs = new FileStream("PARNI.txt", FileMode.Create);

            StreamWriter sw = new StreamWriter(fs);

            for (int i = 1; i <= 100; i++)
                if (i % 2 == 0) 
                {
                    sw.WriteLine(i);
                    
                }
            sw.Flush();
            sw.Close();
            fs.Close();

            
        }
    }
}
