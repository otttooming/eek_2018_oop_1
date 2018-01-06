using System;
using System.Collections;
using System.Collections.Generic;

namespace eek_2018_oop
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            SantaClause Chris = new SantaClause("Chris Cringle", 1567, 4, 55);
            SantaClause Karmpus = new SantaClause("Karmpus", 2017, 34, 12);
            SantaClause KwanzaBot = new SantaClause("KwanzaBot", 1982, 1, 22);
            SantaClause Kringle = new SantaClause("Kringle", 987);

            SantaClause CloneSanta = new SantaClause(Chris);

            /*
                Clone santa
             */
            Console.WriteLine("Clone Santa");
            CloneSanta.printMe("Clone Santa: Messange inside");

            SantaClause name = Chris;

            int age = name.calcAge();
            double weight = name.calcAvgPresentWeight();

            name.printMe();


            Console.WriteLine("\nAge={0,4} Weight={1,4:F1}", age, weight);

            name.changePresents(55, 100);
            name.printMe();

            /*
                Array
            */
            ArrayList AllSantas = new ArrayList();
            AllSantas.Add(Chris);
            AllSantas.Add(Karmpus);
            AllSantas.Add(Kringle);
            AllSantas.Insert(1, KwanzaBot);
            AllSantas.Add(new SantaClause("New Santa", 1943, 22, 1));

            Console.WriteLine("\nChristmas characters array");
            foreach(SantaClause x in AllSantas)
            {
                x.printMe();
            }

            /*
                List array
            */
            List<SantaClause> AllSantasList = new List<SantaClause>();
            AllSantasList.Add(Chris);
            AllSantasList.Add(Karmpus);
            AllSantasList.Add(Kringle);
            AllSantasList.Insert(1, KwanzaBot);
            AllSantasList.Add(new SantaClause("New Santa", 1943, 22, 1));

            Console.WriteLine("\nChristmas characters array: LIST");
            foreach (SantaClause x in AllSantasList)
            {
                x.printMe();
            }

            Console.Read();
        }
    }
}
