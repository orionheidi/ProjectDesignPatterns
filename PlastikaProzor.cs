using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatDesignPatterns
{
    class PlastikaProzor : Prozor
    {
        public PlastikaProzor()
        {
            this.Cena = 350;
            string cenaStr = Cena.ToString();
            this.Naziv = "plastika prozor";
            this.Opis = this.Naziv + " , cena: " + cenaStr + " kolicina: ";


        }
    }
}
