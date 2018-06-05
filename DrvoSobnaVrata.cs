using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatDesignPatterns
{
    class DrvoSobnaVrata : SobnaVrata
    {
        public DrvoSobnaVrata()
        {
            this.Cena = 200;
            string cenaStr = Cena.ToString();
            this.Naziv = "drvo - sobna vrata";
            this.Opis = this.Naziv + " , cena: " + cenaStr +  " , a kolicina ";


        }
    }
}
