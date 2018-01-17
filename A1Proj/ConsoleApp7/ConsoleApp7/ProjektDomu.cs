using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    abstract class ProjektDomu
    {
        public Dom dom;

        public void NowyDom()
        {
            Dom dom = new Dom();
        }

        abstract public void PomalujElewacje(Kolor kolor)
        {

        }

        public override string ToString()
        {
            return ("dom " + dom);
        }

        public virtual void WstawOkna(string rodzajOkien)
        {
            this.dom.okno = rodzajOkien;
        }

        public virtual void ZamontujDrzwi(string rodzajDrzwi)
        {
            this.dom.drzwi = rodzajDrzwi;

        }
    }
}
