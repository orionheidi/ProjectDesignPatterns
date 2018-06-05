using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatDesignPatterns
{
    class BuildPlaninskaKuca : KucaBuilder
    {

        protected PlaninskaKuca pk;

        public BuildPlaninskaKuca()
        {
            this.pk = new PlaninskaKuca();
        }

        public void buidKrov()
        {
            pk.SetKrov(new DrveniKrov());
        }

        public void buildZid()
        {
            pk.SetZid(new BalvanZid());
        }

        public void buildPloca()
        {
            pk.SetPloca(new AvramekoPloca());
        }

        public void buildProzor()
        {
            pk.SetProzor(new DrvoProzor());
        }

        public void buildSobnaVrata()
        {
            pk.SetSobnaVrata(new DrvoSobnaVrata());
        }

        public void buildTemelj()
        {
            pk.SetTemelj(new KameniTemelj());
        }

        public void buildUlaznaVrata()
        {
            pk.SetUlaznaVrata(new DrvoUlaznaVrata());
        }

        public Kuca getKuca()
        {
            return this.pk;
        }
    }
}
