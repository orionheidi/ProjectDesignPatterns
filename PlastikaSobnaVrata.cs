using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatDesignPatterns
{
    class PlastikaSobnaVrata : SobnaVrata
    {
        public PlastikaSobnaVrata()
        {
            this.Cena = 150;
            string cenaStr = Cena.ToString();
            this.Naziv = "plastika sobna vrata";
            this.Opis = this.Naziv + " , cena: " + cenaStr + " kolicina: ";


        }
    }
}
