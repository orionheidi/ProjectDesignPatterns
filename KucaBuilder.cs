using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatDesignPatterns
{
    interface KucaBuilder
    {
        void buildProzor();
        void buildUlaznaVrata();
        void buildSobnaVrata();
        void buildTemelj();
        void buildPloca();
        void buildZid();
        void buidKrov();


        Kuca getKuca();
    }
}
