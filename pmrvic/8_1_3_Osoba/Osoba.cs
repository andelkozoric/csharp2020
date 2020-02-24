using System;

namespace _8_1_3_Osoba
{
    internal class Osoba
    {
        private string prezime;
        private string ime;
        private DateTime datrod;

        public string Ime
        {
            get => ime;
            set => ime = Slova.PrvoVeliko(value);
        }
        public string Prezime
        {
            get => prezime;
            set => prezime = Slova.PrvoVeliko(value);
        }
        public string Datrod
        {
            get => datrod.ToString();
            set => datrod = DateTime.Parse(value);
<<<<<<< HEAD

        }
        public object BrojGodina {
            get =>  DateTime.Now - this.datrod;
             
                 }
=======
        }
        public double BrojGodina
        {
            get
            {
                TimeSpan TS = DateTime.Now - this.datrod;
                return TS.TotalDays / 365.25;
            }
            // private set;  // trebamo readonly
        }
>>>>>>> c606924283b27a469339b2353a50582715f63607

        public override string ToString()
        {
            return $"{Ime} {Prezime} naš najdraži";
        }

        internal void IspisBrojGodina()
        {
<<<<<<< HEAD
            Console.WriteLine($"Osoba {this.Ime} {this.Prezime} ima {this.BrojGodina}");
=======
            Console.WriteLine($"Osoba {this.Ime} {this.Prezime} ima {this.BrojGodina:f1}");
>>>>>>> c606924283b27a469339b2353a50582715f63607
        }
    }
}