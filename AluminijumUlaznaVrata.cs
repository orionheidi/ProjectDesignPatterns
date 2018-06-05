using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatDesignPatterns
{
    class AluminijumUlaznaVrata : UlaznaVrata
    {
        public AluminijumUlaznaVrata()
        {
            this.Cena = Cena;
            string cenaStr = Cena.ToString();
            this.Naziv = "aluminijum ulazna vrata";
            this.Opis = this.Naziv + " , cena: " + cenaStr;


        }
    }
}
