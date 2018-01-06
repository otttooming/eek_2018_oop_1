using System;

namespace eek_2018_oop
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Read();

            SantaClause Chris = new SantaClause("Chris Cringle", 1567, 13, 55);

            Chris.printMe();
        }
    }
}
