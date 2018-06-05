using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatDesignPatterns
{
    class CrepKrov : Krov
    {
        public CrepKrov()
        {
            this.cena = 7000;
            string cenaStr = Cena.ToString();
            this.Naziv = "crep krov";
            this.opis = this.Naziv + ", cena " + cenaStr;


        }
    }
}
