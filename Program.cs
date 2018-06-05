using System;
using System.Collections.Generic;

namespace ProjekatDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            FabrikaDeloviTemelja fabrika = new FabrikaDeloviTemelja();
            Temelj temelj = fabrika.MakeTemelj("betonski");
            Temelj temelj2 = fabrika.MakeTemelj("kameni");

            Console.WriteLine("SIMPLE FACTORY");
            Console.WriteLine("Napravljen je : " + temelj.Naziv);
            Console.WriteLine("Napravljen je : " + temelj2.Naziv);

            ITemeljFabrika luxFabrika = new LuksuznaTemeljFabrika();
            BetonskiTemeljLux btl = (BetonskiTemeljLux)luxFabrika.createTemelj("beton");

            ITemeljFabrika osnovnaFabrika = new OsnovaTemeljFabrika();
            KameniTemelj kt = (KameniTemelj)osnovnaFabrika.createTemelj("kamen");

            Console.WriteLine("FACTORY METHOD");
            Console.WriteLine("Napravljen je : " + btl.Opis + " u luksuznoj fabrici.");
            Console.WriteLine("Napravljen je : " + kt.Opis + " u osnovnoj fabrici.");

            Console.WriteLine("ABSTRACT FACTORY");
            IKucaApstract factoryA = new KucaAbstraktFabrikaA();
            KucaAbstractKlijent klijentA = new KucaAbstractKlijent(factoryA, "drveni");

            Console.WriteLine("factroyA :");
            Console.WriteLine(klijentA.GetProzorName());
            Console.WriteLine(klijentA.GetVrataUlaznaName());
            Console.WriteLine(klijentA.GetVrataSobnaName());


            IKucaApstract factoryB = new KucaAbstraktFabrikaB();
            KucaAbstractKlijent klijentB = new KucaAbstractKlijent(factoryB, "aluminijumski");

            Console.WriteLine("FactoryB :");
            Console.WriteLine(klijentB.GetProzorName());
            Console.WriteLine(klijentB.GetVrataUlaznaName());
            Console.WriteLine(klijentB.GetVrataSobnaName());

            klijentB = new KucaAbstractKlijent(factoryB, "plasticni");
            Console.WriteLine(klijentB.GetProzorName());
            Console.WriteLine(klijentB.GetVrataUlaznaName());
            Console.WriteLine(klijentB.GetVrataSobnaName());

            Console.WriteLine("BUILDER");
            Console.WriteLine("BUILDING PLANINSKA KUCA");

            KucaBuilder planinsakKuca = new BuildPlaninskaKuca();
            KucaEngineer ke = new KucaEngineer(planinsakKuca);
            ke.makeKuca();
            PlaninskaKuca firstPK =(PlaninskaKuca)ke.getKuca();

            Console.WriteLine("Planinska kuca prozori: " + firstPK.DrvoProzor.Opis + firstPK.KolicinaP);
            Console.WriteLine("Planinska kuca sobnaVrata: " + firstPK.DrvoSobnaVrata.Opis + firstPK.KolicinaSV);
            Console.WriteLine("Planinska kuca ulaznaVrata: " + firstPK.DrvoUlaznaVrata.Opis + firstPK.KolicinaUV);
            Console.WriteLine("Planinska kuca temelj: " + firstPK.KameniTemelj.Opis);
            Console.WriteLine("Planinska kuca ploca: " + firstPK.AvramekoPloca.Opis);
            Console.WriteLine("Planinska kuca zid: " + firstPK.BalvanZid.Opis);
            Console.WriteLine("Planinska kuca krov: " + firstPK.DrveniKrov.Opis);
            Console.WriteLine("Ukupna cena planinske kuce, pomnozena faktorom 5 je: " + firstPK.IzracunajCenuKuce());

            Console.WriteLine("BUILDING VIKEND KUCA");

            KucaBuilder vikendKuca = new BuildVikendKucu();
            ke = new KucaEngineer(vikendKuca);
            ke.makeKuca();
            VikendKuca secondVK = (VikendKuca)ke.getKuca();

            Console.WriteLine("Vikend kuca prozori: " + secondVK.PlastikaProzor.Opis  + secondVK.KolicinaP);
            Console.WriteLine("Vikend kuca sobnaVrata: " + secondVK.PlastikaSobnaVrata .Opis + secondVK.KolicinaSV);
            Console.WriteLine("Vikend kuca ulaznaVrata: " + secondVK.PlastikaUlaznaVrata.Opis + secondVK.KolicinaUV);
            Console.WriteLine("Vikend kuca temelj: " + secondVK.BetonskiTemelj.Opis);
            Console.WriteLine("Vikend kuca ploca: " + secondVK.BetonskaPloca.Opis);
            Console.WriteLine("Vikend kuca zid: " + secondVK.SendvicZid.Opis);
            Console.WriteLine("Vikend kuca krov: " + secondVK.CrepKrov.Opis);
            Console.WriteLine("Ukupna cena vikend kuce, pomnozena faktorom 4 je: " + secondVK.IzracunajCenuKuce());


            Console.WriteLine("SVE KUCE SKI NASELJA");
            List<PlaninskaKuca> planinske = new List<PlaninskaKuca>();
            planinske.Add(firstPK);

            KucaBuilder planinsakKuca2 = new BuildPlaninskaKuca();
            ke = new KucaEngineer(planinsakKuca2);
            ke.makeKuca();
            PlaninskaKuca secondPK = (PlaninskaKuca)ke.getKuca();
            planinske.Add(secondPK);
            KucaBuilder planinsakKuca3 = new BuildPlaninskaKuca();
            ke = new KucaEngineer(planinsakKuca3);
            ke.makeKuca();
            PlaninskaKuca thirdPK = (PlaninskaKuca)ke.getKuca();
            planinske.Add(thirdPK);
            KucaBuilder planinsakKuca4 = new BuildPlaninskaKuca();
            ke = new KucaEngineer(planinsakKuca4);
            ke.makeKuca();
            PlaninskaKuca forthPK = (PlaninskaKuca)ke.getKuca();
            planinske.Add(forthPK);
            KucaBuilder planinsakKuca5 = new BuildPlaninskaKuca();
            ke = new KucaEngineer(planinsakKuca5);
            ke.makeKuca();
            PlaninskaKuca fifthPK = (PlaninskaKuca)ke.getKuca();
            planinske.Add(fifthPK);


            List<VikendKuca> vikendske = new List<VikendKuca>();
            vikendske.Add(secondVK);
            KucaBuilder vikendKuca2 = new BuildVikendKucu();
            ke = new KucaEngineer(vikendKuca2);
            ke.makeKuca();
            VikendKuca VK2 = (VikendKuca)ke.getKuca();
            vikendske.Add(VK2);
            KucaBuilder vikendKuca3 = new BuildVikendKucu();
            ke = new KucaEngineer(vikendKuca3);
            ke.makeKuca();
            VikendKuca VK3 = (VikendKuca)ke.getKuca();
            vikendske.Add(VK3);
            KucaBuilder vikendKuca4 = new BuildVikendKucu();
            ke = new KucaEngineer(vikendKuca4);
            ke.makeKuca();
            VikendKuca VK4 = (VikendKuca)ke.getKuca();
            vikendske.Add(VK4);

            SkiNaselje skiNaselje = new SkiNaselje(planinske,vikendske);
            skiNaselje.SkiNaseljeRepresentation();


            Console.WriteLine("PROTOTYPE");

            Console.WriteLine("PLANINSKA KUCA CLONE");

            CloneFactory kucaMaker = new CloneFactory();

            PlaninskaKuca planinkaCopy =(PlaninskaKuca)kucaMaker.Kloniraj(firstPK);
          
            Console.WriteLine(planinkaCopy.ToStrPlaninska());


            Console.WriteLine("VIKEND KUCA CLONE");

            kucaMaker = new CloneFactory();

            VikendKuca vikendkaCopy = (VikendKuca)kucaMaker.Kloniraj(secondVK);

            Console.WriteLine(vikendkaCopy.ToStrVikendska());




            Console.ReadLine();
        }
    }
}
