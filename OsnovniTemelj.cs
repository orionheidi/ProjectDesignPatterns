using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatDesignPatterns
{
    abstract class OsnovniTemelj : Temelj
    {
        protected string dodatak;

        public OsnovniTemelj()
        {
            this.cena = Cena;
            string cenaStr = Cena.ToString();
            this.dodatak = "osnovni";
            this.opis = this.Naziv + " " + this.dodatak + " , cena:  " + cenaStr;

        }


        public string Dodatak
        {
            get { return dodatak; }
            set { this.dodatak = value; }
        }

    }
}
