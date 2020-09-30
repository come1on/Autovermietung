using System;
using System.Collections.Generic;
using System.Text;

namespace Sixt
{
    class Kunden : Person
    {
        public static int AnzahlKunden = 0;
        public Kunden()
        {
            AnzahlKunden++;
        }
    }
}
