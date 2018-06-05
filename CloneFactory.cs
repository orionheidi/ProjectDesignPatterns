using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatDesignPatterns
{
    class CloneFactory
    {

        public Kuca  Kloniraj(Kuca kucaSample)
        {
            return (Kuca)kucaSample.Clone();
        }
    }
}
