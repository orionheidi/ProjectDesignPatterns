using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatDesignPatterns
{
    class DrvoUlaznaVrata : UlaznaVrata
    {
        public DrvoUlaznaVrata()
        {
            this.Cena = 250;
            string cenaStr = Cena.ToString();
            this.Naziv = "drvo - ulazna vrata";
            this.Opis = this.Naziv + " , cena: " + cenaStr + " ,a kolicina " ;


        }
    }
}
