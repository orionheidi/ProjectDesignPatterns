using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatDesignPatterns
{
    class PlaninskaKuca : Kuca, PlanKuce
    {
        protected KameniTemelj kameniTemelj;
        protected AvramekoPloca aPloca;
        protected BalvanZid balvanZid;
        protected DrveniKrov drveniKrov;
        protected DrvoProzor prozor;
        protected DrvoSobnaVrata sobnaVrata;
        protected DrvoUlaznaVrata ulaznaVrata;
        protected int kolicinaP = 0;
        protected int kolicinaSV = 0;
        protected int kolicinaUV = 0;
        protected double ukupnaCena = 0;

        public double IzracunajCenuKuce()
        {
            ukupnaCena = ((kameniTemelj.Cena + aPloca.Cena + balvanZid.Cena + drveniKrov.Cena) +
                (prozor.Cena *kolicinaP +sobnaVrata.Cena * KolicinaSV + ulaznaVrata.Cena * KolicinaUV )) * 5;
                return ukupnaCena;
        }


        public void SetProzor(Prozor prozor)
        {
            this.prozor =(DrvoProzor)prozor;
            this.kolicinaP = kolicinaP + 3;
        }

        public void SetSobnaVrata(SobnaVrata sobnaVrata)
        {
            this.sobnaVrata = (DrvoSobnaVrata)sobnaVrata;
            this.kolicinaSV = kolicinaSV + 2;
        }

        public void SetUlaznaVrata(UlaznaVrata ulaznaVrata)
        {
            this.ulaznaVrata = (DrvoUlaznaVrata)ulaznaVrata;
            this.kolicinaUV = kolicinaUV + 1;
        }

        public void SetTemelj(Temelj temelj)
        {
            this.kameniTemelj = (KameniTemelj)temelj;
        }

        public void SetPloca(Ploca ploca)
        {
            this.aPloca = (AvramekoPloca)ploca;
        }

        public void SetZid(Zid zid)
        {
            this.balvanZid = (BalvanZid)zid;
        }

        public void SetKrov(Krov krov)
        {
            this.drveniKrov = (DrveniKrov) krov;
        }

        public DrvoProzor DrvoProzor
        {
            get { return prozor; }
            set { prozor = value; }
        }

        public DrvoSobnaVrata DrvoSobnaVrata
        {
            get { return sobnaVrata; }
            set { sobnaVrata = value; }
        }

        public DrvoUlaznaVrata DrvoUlaznaVrata
        {
            get { return ulaznaVrata; }
            set { ulaznaVrata = value; }
        }

        public KameniTemelj KameniTemelj
        {
            get { return kameniTemelj; }
            set { kameniTemelj = value; }
        }

        public AvramekoPloca AvramekoPloca
        {
            get { return aPloca; }
            set { aPloca = value; }
        }

        public BalvanZid BalvanZid
        {
            get { return balvanZid; }
            set { balvanZid = value; }
        }

        public DrveniKrov DrveniKrov
        {
            get { return drveniKrov; }
            set { drveniKrov = value; }
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

        public string ToStrPlaninska()
        {
            return this.KameniTemelj.Opis  + " " + this.AvramekoPloca.Opis  + " " + this.BalvanZid.Opis  + " " + this.DrveniKrov.Opis + this.DrvoProzor.Opis + this.KolicinaP + " "  + this.DrvoSobnaVrata.Opis  + this.KolicinaSV + " "  + this.DrvoUlaznaVrata.Opis + this.KolicinaUV + ". " ;
        }

        public new object Clone()
        {
            Kuca kuca = null;

            try
            {
                kuca = (PlaninskaKuca) base.MemberwiseClone();
            }
            catch(Exception e)
            {
                Console.WriteLine("Planinska kuca se ne moze klonirati.", e);
            }
            return kuca;
        }
    }
}
