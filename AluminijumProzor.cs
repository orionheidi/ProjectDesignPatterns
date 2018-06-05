using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatDesignPatterns
{
    class AluminijumProzor : Prozor
    {
        public AluminijumProzor()
        {
            this.Cena = Cena;
            string cenaStr = Cena.ToString();
            this.Naziv = "aluminijum prozor";
            this.Opis = this.Naziv + " , cena: " + cenaStr;


        }
    }
}
