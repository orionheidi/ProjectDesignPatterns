﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatDesignPatterns
{
    class Vrata : Kuca
    {
        protected double cena;
        protected string opis;
        protected string naziv;
   


        public string Naziv
        {
            get { return naziv; }
            set { this.naziv = value; }
        }

        public double Cena
        {
            get { return cena; }
            set { this.cena = value; }
        }

        public string Opis
        {
            get { return opis; }
            set { this.opis = value; }
        }

       
    }
}
