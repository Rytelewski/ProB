﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Dom
    {
        private string drzwi;
        private Kolor kolorElewacji;
        private string okno;

        public void PomalujElewacje(Kolor kolor)
        {
            this.kolorElewacji = kolor;
        }

        public override string ToString()
        {
            return ("Okna " + okno + " Drzwi " + drzwi + " Kolor elewacji " + kolorElewacji);
        }

        public void WstawOkna(string okno)
        {
            this.okno = okno;
        }

        public void ZamontujDrzwi(string drzwi)
        {
            this.drzwi = drzwi;
        }
    }
}
