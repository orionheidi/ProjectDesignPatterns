using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatDesignPatterns
{
    class BalvanZid : Zid
    {
        public BalvanZid()

        {
            this.cena = 5000;
            string cenaStr = Cena.ToString();
            this.Naziv = "balvan zid";
            this.opis = this.Naziv + "cena: " + cenaStr;

        }
    }
}
