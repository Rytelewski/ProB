using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class SzefBudowy
    {
        private ProjektDomu projektDomu;

        public void Buduj(string rodzajOkien, string rodzajDrzwi, Kolor kolor)
        {


            NowyDom();

            WstawOkna();

            ZamontujDrzwi(rodzajDrzwi);

            PomalujElewacje(kolor);

        }

        public override string ToString()
        {
            return (" ");
        }

        public void WybierzProjekt(ProjektDomu projekt)
        {
            this.projektDomu = projekt;
        }
    }
}
