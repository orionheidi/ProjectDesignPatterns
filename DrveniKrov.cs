using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatDesignPatterns
{
    class DrveniKrov : Krov
    {
        public DrveniKrov()
        {
            this.cena = 5000;
            string cenaStr = Cena.ToString();
            this.Naziv = "drveni krov";
            this.opis = this.Naziv + cenaStr;

        }
    }
}
