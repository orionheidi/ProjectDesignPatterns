using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatDesignPatterns
{
    class OsnovaTemeljFabrika : ITemeljFabrika
    {

        public Temelj createTemelj(string tip)
        {
            switch (tip)
            {
                case "beton":

                    return new BetonskiTemelj();

                case "kamen":

                    return new KameniTemelj();

                default:

                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", tip));


            }
       
        }


    }
}
