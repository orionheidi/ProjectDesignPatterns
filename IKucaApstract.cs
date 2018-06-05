using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatDesignPatterns
{
    interface IKucaApstract
    {
        Prozor GetProzor(string tip);
        UlaznaVrata GetVrata(string tip);
        SobnaVrata GetVrata1(string tip);
    }
}
