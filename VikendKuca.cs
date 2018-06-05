using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatDesignPatterns
{
    class VikendKuca : Kuca, PlanKuce
    {

        protected BetonskiTemelj betonskiTemelj;
        protected BetonskaPloca betonskaPloca;
        protected SendvicZid sendvicZid;
        protected CrepKrov crepKrov;
        protected PlastikaProzor plastikaProzor;
        protected PlastikaUlaznaVrata pUlVrata;
        protected PlastikaSobnaVrata pSobnaVrata;
        protected int kolicinaP = 0;
        protected int kolicinaSV = 0;
        protected int kolicinaUV = 0;
        protected double ukupnaCena = 0;

        public void SetKrov(Krov krov)
        {
            this.crepKrov = (CrepKrov)krov;
        }

        public void SetPloca(Ploca ploca)
        {
            this.betonskaPloca = (BetonskaPloca)ploca;
        }

        public void SetProzor(Prozor prozor)
        {
            this.plastikaProzor = (PlastikaProzor)prozor;
            this.kolicinaP = kolicinaP + 4;
        }

        public void SetSobnaVrata(SobnaVrata sobnaVrata)
        {
            this.pSobnaVrata = (PlastikaSobnaVrata)sobnaVrata;
            this.KolicinaSV = kolicinaSV + 4;
        }

        public void SetTemelj(Temelj temelj)
        {
            this.betonskiTemelj = (BetonskiTemelj)temelj;
            
        }

        public void SetUlaznaVrata(UlaznaVrata ulaznaVrata)
        {
            this.pUlVrata = (PlastikaUlaznaVrata)ulaznaVrata;
            this.kolicinaUV = kolicinaUV + 1;
        }

        public void SetZid(Zid zid)
        {
            this.sendvicZid =(SendvicZid) zid;
        }

        public double IzracunajCenuKuce()
        {
            ukupnaCena = ((betonskiTemelj.Cena + betonskaPloca.Cena + sendvicZid.Cena + crepKrov.Cena) +
                (plastikaProzor.Cena * kolicinaP + pSobnaVrata.Cena * KolicinaSV + pUlVrata.Cena * KolicinaUV)) * 4;
            return ukupnaCena;
        }

        public PlastikaProzor PlastikaProzor 
        {
            get { return plastikaProzor; }
            set { plastikaProzor = value; }
        }

        public PlastikaSobnaVrata PlastikaSobnaVrata
        {
            get { return pSobnaVrata; }
            set { pSobnaVrata = value; }
        }

        public PlastikaUlaznaVrata PlastikaUlaznaVrata
        {
            get { return pUlVrata; }
            set { pUlVrata = value; }
        }

        public BetonskiTemelj BetonskiTemelj
        {
            get { return betonskiTemelj; }
            set { betonskiTemelj = value; }
        }

        public BetonskaPloca BetonskaPloca
        {
            get { return betonskaPloca; }
            set { betonskaPloca = value; }
        }

        public SendvicZid SendvicZid
        {
            get { return sendvicZid; }
            set { sendvicZid = value; }
        }

        public CrepKrov CrepKrov
        {
            get { return crepKrov; }
            set { crepKrov = value; }
        }

        public int KolicinaP
        {
            get { return kolicinaP; }
            set { kolicinaP = value; }
        }

        public int KolicinaSV
        {
            get { return kolicinaSV; }
            set { kolicinaSV = value; }
        }

        public int KolicinaUV
        {
            get { return kolicinaUV; }
            set { kolicinaUV = value; }
        }

        public string ToStrVikendska()
        {
            return this.BetonskiTemelj.Opis + " " + this.BetonskaPloca.Opis + " " + this.SendvicZid.Opis + " " + this.CrepKrov.Opis + " " + this.PlastikaProzor.Opis + this.KolicinaP + " "  + this.PlastikaSobnaVrata.Opis +this.KolicinaSV + " " + this.PlastikaUlaznaVrata.Opis + this.KolicinaUV + ". ";
        }

        public new object Clone()
        {
           Kuca kuca = null;

            try
            {
                kuca = (VikendKuca)base.MemberwiseClone();
            }
            catch (Exception e)
            {
                Console.WriteLine("Planinska kuca se ne moze klonirati.", e);
            }
            return kuca;
        }
    }
}
