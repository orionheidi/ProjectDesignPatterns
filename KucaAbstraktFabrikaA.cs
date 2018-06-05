using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatDesignPatterns
{
    class KucaAbstraktFabrikaA : IKucaApstract
    {

        public Prozor GetProzor(string tip)
        {
            switch (tip)
            {
                case "drveni":
                    return new DrvoProzor();
                case "plasticni":
                    return new PlastikaProzor();
                case "aluminijumski":
                    return new AluminijumProzor();
                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", tip));
            }
        }

        public UlaznaVrata GetVrata(string tip)
        {
            switch (tip)
            {
                case "drveni":
                    return new DrvoUlaznaVrata();
                case "plasticni":
                    return new PlastikaUlaznaVrata();
                case "aluminijumski":
                    return new AluminijumUlaznaVrata();
                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", tip));
            }
        }

        public SobnaVrata GetVrata1(string tip)
        {
            switch (tip)
            {
                case "drveni":
                    return new DrvoSobnaVrata();
                case "plasticni":
                    return new PlastikaSobnaVrata();
                case "aluminijumski":
                    return new AluminijumSobnaVrata();
                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", tip));
            }
        }
    }
}