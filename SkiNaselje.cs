using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatDesignPatterns
{
    class SkiNaselje
    {
        List<PlaninskaKuca> planinskeKuce;
        List<VikendKuca> vikendKuce;

        public SkiNaselje(List<PlaninskaKuca> pk, List<VikendKuca> vk)
        {
            this.planinskeKuce = pk;
            this.vikendKuce = vk;
        }


        public List<PlaninskaKuca> Planinske
        {
            get { return planinskeKuce ; }
            set { this.planinskeKuce  = value; }
        }

        public List<VikendKuca> Vikend
        {
            get { return vikendKuce; }
            set { this.vikendKuce = value; }
        }

        public void SkiNaseljeRepresentation()
        {
            foreach(PlaninskaKuca pk in planinskeKuce)
            {
                Console.WriteLine("Planinske Kuce su: " + pk.ToStrPlaninska());
            }

            foreach (VikendKuca  vk in vikendKuce)
            {
                Console.WriteLine("Vikend Kuce su: " + vk.ToStrVikendska());
            }

        }
    }
}
