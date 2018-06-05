using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatDesignPatterns
{
    class KucaAbstractKlijent
    {
        Prozor prozor;
        UlaznaVrata uv;
        SobnaVrata sv;

        public KucaAbstractKlijent(IKucaApstract factory, string tip)
        {
            prozor = factory.GetProzor(tip);
            uv = factory.GetVrata(tip);
            sv = factory.GetVrata1(tip);
        }

        public string GetProzorName()
        {
            return prozor.Naziv;
        }

        public string GetVrataUlaznaName()
        {
            return uv.Naziv;
        }

        public string GetVrataSobnaName()
        {
            return sv.Naziv;
        }
    }
}
