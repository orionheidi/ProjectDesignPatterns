using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatDesignPatterns
{
    class AluminijumSobnaVrata : SobnaVrata
    {
        public AluminijumSobnaVrata()
        {
            this.Cena = Cena;
            string cenaStr = Cena.ToString();
            this.Naziv = "aluminijum sobna vrata";
            this.Opis = this.Naziv + " , cena: " + cenaStr;


        }
    }
}
