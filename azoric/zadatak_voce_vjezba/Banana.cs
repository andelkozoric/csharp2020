using System;
using System.Collections.Generic;
using System.Text;

namespace zadatak_voce_vjezba
{
    internal class Banana : Voce
    {
        private int duljina;

        public Banana(int v)
        {
            this.duljina = v;
            
        }

        public override string ToString()
        {
            return $"Voce: banana, duljina {duljina}";
        }
    }
}
