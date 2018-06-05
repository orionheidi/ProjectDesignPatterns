using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatDesignPatterns
{
    class PlastikaUlaznaVrata : UlaznaVrata
    {
        public PlastikaUlaznaVrata()
        {
            this.Cena = 280;
            string cenaStr = Cena.ToString();
            this.Naziv = "plastika ulazna vrata";
            this.Opis = this.Naziv + " , cena: " + cenaStr + " kolicina: ";


        }
    }
}
