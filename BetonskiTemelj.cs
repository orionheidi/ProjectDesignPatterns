using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatDesignPatterns
{
    class BetonskiTemelj : OsnovniTemelj
    {

        public BetonskiTemelj()
        {
            this.cena = 3000;
            string cenaStr = Cena.ToString();
            this.Naziv = "betonski temelj";
            this.opis = this.Naziv + " " + this.Dodatak + " , cena:  " + cenaStr;



        }
    }
}
