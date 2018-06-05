using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatDesignPatterns
{
    class AvramekoPloca : Ploca
    {
        public AvramekoPloca()
        {
            this.Cena = 3000;
            string cenaStr = Cena.ToString();
            this.Naziv = "avrameko ploca";
            this.Opis = this.Naziv + cenaStr;

        }
    }
}
