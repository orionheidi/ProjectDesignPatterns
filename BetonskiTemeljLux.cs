using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatDesignPatterns
{
    class BetonskiTemeljLux : LuksuzniTemelj
    {
        public BetonskiTemeljLux()
        {
            this.cena = Cena;
            string cenaStr = Cena.ToString();
            this.Naziv = "betonski temelj";
            this.opis = this.Naziv + " " + this.Dodatak + " , cena: " + cenaStr;


        }
    }
}

