using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatDesignPatterns
{
    class BetonskaPloca : Ploca
    {
        public BetonskaPloca()
        {
            this.Cena = 6000;
            string cenaStr = Cena.ToString();
            this.Naziv = "betonska ploca";
            this.Opis = this.Naziv + " , a cena " + cenaStr;


        }
    }
}
