using System;

namespace _8_2_doesg_varij
{
    internal class MojStatic
    {
        internal static double Zbroj(double broj1, double broj2)
        {
            return broj1 + broj2;
        }

        internal static double Kub(double broj1)
        {
            return Math.Pow(broj1, 3);
        }

        internal static int CelzijFahrenheit(int broj1)
        {
            return broj1 * (9/5) + 32;
        }
    }
}