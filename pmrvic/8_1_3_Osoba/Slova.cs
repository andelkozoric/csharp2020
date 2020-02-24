using System;
using System.Linq;

namespace _8_1_3_Osoba
{
    public static class Slova
    {
        public static string PrvoVeliko(string value)
        {
<<<<<<< HEAD
            value = value.Trim(); // brise prazni prostor sa početka i kraja stringa
            return char.ToUpper(value.First()) + value.Substring(1).ToLower(); // prvo veliko pocetno slovo
=======
            value = value.Trim();  // brise praznine sa početka i kraja stringa
            return char.ToUpper(value.First()) + value.Substring(1).ToLower();  // prvo velko
>>>>>>> c606924283b27a469339b2353a50582715f63607
        }
    }
}