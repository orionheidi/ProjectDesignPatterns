using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatDesignPatterns
{
    class LuksuznaTemeljFabrika : ITemeljFabrika
    {

        public Temelj createTemelj(string tip)
        {
            switch (tip)
            {
                case "beton":

                    return new BetonskiTemeljLux();
                case "kamen":

                    return new BetonskiTemeljLux();
                default:

                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", tip));

            }
        }

        
    }
}
