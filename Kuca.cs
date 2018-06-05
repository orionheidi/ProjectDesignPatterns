using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatDesignPatterns
{
    abstract class Kuca : ICloneable 
    {
        private static Kuca id;


        protected Kuca()
        {

        }

        public static Kuca Id()
        {
            if (id == null)
            {
                id = new PlaninskaKuca();
            }

            return id;
        }

        public object Clone()
        {
            Kuca kuca = null;

            try
            {
                kuca = (Kuca)base.MemberwiseClone();
            }
            catch (Exception e)
            {
                Console.WriteLine("Planinska kuca se ne moze klonirati.", e);
            }
            return kuca;
        }
    }
}
