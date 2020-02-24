using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _8_3_1_vozilo
{
    class Automobili : CollectionBase
    {
        internal int Add(Automobil a1)
        {
            return InnerList.Add(a1);
        }

        internal void Remove(Automobil a1)
        {
            InnerList.Remove(a1);
        }
        //ovim dobivamo mogućnost ispisa foreach
        public Automobil this[int index]
        {
            get => (Automobil)InnerList[index];
        }
    }
}
