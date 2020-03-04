using System;
using System.Collections;
using System.Text;

namespace _9._1._5.koliko_se_puta_ponavlja_rijec
{
    class Program
    {
        static void Main(string[] args)
        {
            // Napisite program koji trazti unos recenice i zatim broji oiliko puta se pojavljuje koja rijec iz te recenice
            //Program treba ignorirati velika i mala slova
            Console.WriteLine("Unesite recenicu");

            string recenica = Console.ReadLine();

            //prvo uzimamo sve rijeci iz recenice(moze biti i duplikata)
            string[] arrSveRijeci = recenica.Split(' ');

            //zatim instanciramo objekt klase ArrayList u koji cemo spremiti samo po jednu od svake rijeci koja se pojavljuje
            ArrayList arrPojedineRijeci = new ArrayList();

            //Pregledavamo sve rijeci iz recenice
            for (int i = 0; i < arrSveRijeci.Length; i++)
            {
                //diuzemo zastavicu za dodavanje rijeci
                bool dodaj = true;

                //pregledavamo i sve vec dodane pojedine rijeci
                for (int j = 0; j < arrPojedineRijeci.Count; j++)

                //ako se ponovo pojavi rijec koja je vec dodana spustamo zastavicu za dodavanje
                {
                    if (arrSveRijeci[i].ToLower() == arrPojedineRijeci[j].ToString().ToLower())
                    {
                        dodaj = false;
                        break;
                    }
                }

                //ako je zastavica za dodavanje dignurta, dodajemo novu rijec
                if (dodaj)
                {
                    arrPojedineRijeci.Add(arrSveRijeci[i]);
                }


                //Ispis
                for (int i = 0; i < arrPojedineRijeci.Count; i++)
                {
                    Console.WriteLine("Rijec {0} - broj pojavljivanja: {1}", arrPojedineRijeci[i], BrojPojavljivanja(arrPojedineRijeci[i].ToString(), recenica));
                }
                Console.ReadLine();
            }
            static int BrojPojavljivanja(string rijec, string recenica)
            {
                int brojPojavljivanja = 0;

                //recenicu pregledavamo slobo po slovo
                for (int i = 0; i <=recenica.Length - rijec.Length; i++)
                {
                    //Na svakoj poziciji provjeravamo pojavljuje li se trazena rijec
                    //ako da nrijoe rijevi vise
                    //proije usporedivanja sva slova pretvararmo u mala
                    if (recenica.Substring(i , rijec.Length).ToLower() == rijec.ToLower())
                    {
                        brojPojavljivanja++;
                    }
                }

                return brojPojavljivanja;
            }



        }
    }
}
