using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatDesignPatterns
{
    interface KucaInterface : ICloneable
    {
        KucaInterface MakeCopy();
    }
}
