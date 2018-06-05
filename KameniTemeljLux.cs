using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatDesignPatterns
{
    class KameniTemeljLux : LuksuzniTemelj
    {
        public KameniTemeljLux()
        {
            this.cena = Cena;
            string cenaStr = Cena.ToString();
            this.Naziv = "kameni temelj";
            this.opis = this.Naziv + " " + this.Dodatak + " " + cenaStr;


        }
    }
}
