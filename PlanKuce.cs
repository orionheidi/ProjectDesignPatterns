using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatDesignPatterns
{
    interface PlanKuce
    {
        void SetProzor(Prozor prozor);
        void SetUlaznaVrata(UlaznaVrata ulaznaVrata);
        void SetSobnaVrata(SobnaVrata sobnaVrata);
        void SetTemelj(Temelj temelj);
        void SetPloca(Ploca ploca);
        void SetZid(Zid zid);
        void SetKrov(Krov krov);
        double IzracunajCenuKuce();
    }
}
