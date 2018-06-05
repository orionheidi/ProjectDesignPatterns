using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatDesignPatterns
{
    class KucaEngineer
    {
        protected KucaBuilder kucaBuilder;

        public KucaEngineer(KucaBuilder kb)
        {
            this.kucaBuilder = kb;

        }

        public Kuca getKuca()
        {
            return this.kucaBuilder.getKuca();
        }

        public void makeKuca()
        {
            this.kucaBuilder.buildProzor();
            this.kucaBuilder.buildSobnaVrata();
            this.kucaBuilder.buildUlaznaVrata();
            this.kucaBuilder.buildTemelj();
            this.kucaBuilder.buildPloca();
            this.kucaBuilder.buildZid();
            this.kucaBuilder.buidKrov();
        }
    }
}