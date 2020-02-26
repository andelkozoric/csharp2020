using System;

namespace _8_Vocarna
{
    internal class Apple:Voce
    {
        

        public double Tezina;
        public new string Boja
        {
            
            set
            {
                Boja = value;
            }
            
        }
        public Apple(double Tezina)
        {
            this.Tezina = Tezina;
            Random r = new Random();
            switch(r.Next(1, 3))
            {
                case 1:this.Boja = "Zelena";break;
                case 2: this.Boja = "Žuta"; break;
                case 3: this.Boja = "Crvena"; break;
            }
            

        }
    }
}