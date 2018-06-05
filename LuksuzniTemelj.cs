using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatDesignPatterns
{
    abstract class LuksuzniTemelj : Temelj
    {
     
        protected string dodatak;
       
        public LuksuzniTemelj()
        {
            this.cena = Cena;
            string cenaStr = Cena.ToString();
            this.dodatak = "luksuzni";
            this.opis = this.Naziv + " " + this.dodatak + " " + cenaStr;


        }



        public string Dodatak
        {
            get { return dodatak; }
            set { this.dodatak = value; }
        }

    }
}
