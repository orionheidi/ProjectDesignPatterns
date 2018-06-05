using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatDesignPatterns
{
    class BuildVikendKucu : KucaBuilder
    {
        protected VikendKuca vikendKuca;

        public BuildVikendKucu()
        {
            this.vikendKuca = new VikendKuca();
        }


        public void buidKrov()
        {
            vikendKuca.SetKrov(new CrepKrov());
        }

        public void buildPloca()
        {
            vikendKuca.SetPloca(new BetonskaPloca());
        }

        public void buildProzor()
        {
            vikendKuca.SetProzor(new PlastikaProzor());
        }

        public void buildSobnaVrata()
        {
            vikendKuca.SetSobnaVrata(new PlastikaSobnaVrata());
        }

        public void buildTemelj()
        {
            vikendKuca.SetTemelj(new BetonskiTemelj());
        }

        public void buildUlaznaVrata()
        {
            vikendKuca.SetUlaznaVrata(new PlastikaUlaznaVrata());
        }

        public void buildZid()
        {
            vikendKuca.SetZid(new SendvicZid());
        }

        public Kuca getKuca()
        {
            return this.vikendKuca;
        }
    }
}
