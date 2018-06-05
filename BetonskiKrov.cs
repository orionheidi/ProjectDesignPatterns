using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatDesignPatterns
{
    class BetonskiKrov : Krov
    {
        public BetonskiKrov()
        {
            this.cena = Cena;
            string cenaStr = Cena.ToString();
            this.Naziv = "betonski krov";
            this.opis = this.Naziv + cenaStr;


        }
    }
}
