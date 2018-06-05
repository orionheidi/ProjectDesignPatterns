using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatDesignPatterns
{
    class FabrikaDeloviTemelja
    {
       public Temelj MakeTemelj(string tip)
        {
            switch (tip)
            {
                case "kameni":
                
                    return new KameniTemelj();

                case "betonski":

                    return new BetonskiTemelj();
            }

            return null;
        }
    }
}

