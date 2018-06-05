using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatDesignPatterns
{
    class SobnaVrata : Vrata
    {
        public SobnaVrata()
        {
            this.cena = Cena;
            string cenaStr = Cena.ToString();
            this.Naziv = "sobna vrata";
            this.opis = this.Naziv +  " , cena:  " + cenaStr + " , a kolicina ";

        }
    }
}
