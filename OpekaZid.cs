using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatDesignPatterns
{
    class OpekaZid : Zid
    {
        public OpekaZid()
        {
            this.cena = Cena;
            string cenaStr = Cena.ToString();
            this.Naziv = "opeka zid";
            this.opis = this.Naziv + cenaStr;


        }
    }
}
