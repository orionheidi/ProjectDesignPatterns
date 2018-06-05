using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatDesignPatterns
{
    class DrvoProzor : Prozor
    {
        public DrvoProzor()
        {

            this.Cena = 300;
            string cenaStr = Cena.ToString();
            this.Naziv = "drvo - prozor";
           // string kolicinaStr = Kolicina.ToString();
            this.Opis = this.Naziv + " , cena: " + cenaStr + " , a kolicina:" ;
          


        }
    }
}
