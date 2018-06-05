using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatDesignPatterns
{
    interface ITemeljFabrika
    {
        Temelj createTemelj(string tip);
        
    }
}
