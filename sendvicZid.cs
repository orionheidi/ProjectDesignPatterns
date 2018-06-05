using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatDesignPatterns
{
    class SendvicZid : Zid
    {
        public SendvicZid()
        {
            this.cena = 8000;
            string cenaStr = Cena.ToString();
            this.Naziv = "sendvic zid";
            this.opis = this.Naziv + " cena " + cenaStr;


        }
    }
}
