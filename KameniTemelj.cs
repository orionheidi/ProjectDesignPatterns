using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatDesignPatterns
{
     class KameniTemelj : OsnovniTemelj
    {
        
        public KameniTemelj()
        {
            this.cena = 2000;
            string cenaStr = Cena.ToString();
            this.Naziv = "kameni temelj";
            this.opis = this.Naziv + " " + this.Dodatak + " , cena:  " + cenaStr;

        }
    }
}
