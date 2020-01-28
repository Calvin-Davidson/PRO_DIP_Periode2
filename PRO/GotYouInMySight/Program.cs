using System;
using AndereNameSpace;

namespace GotYouInMySight
{
    class Program
    {

        // Variable binnen een class ( class = Program )
        int testP = 0;

        static void Main(string[] args)
        {   
            Console.Clear();

            Console.WriteLine("Variable in een class: " + new Program().testP);

            // Functie binnen andere namespace, en een variable in een class in een andere namespace
            new andereclass().run1();
            new andereclass().run2();



            // tijdelijk variable binnen een functie 
            FirstVariable();
            void FirstVariable() {
                int variable = 5;
                Console.WriteLine("De eeste variable binnen een functie is  " + variable);
            }
        }
    }
}

namespace AndereNameSpace
{
    class andereclass
    {
        int TEST = 88;

        public void run1() {
            Console.WriteLine("Variable in een class, in een andere namespace. " + TEST);
        }

        public void run2() {
        int var = 20;
        Console.WriteLine("Dit bericht zit in een andere namespace, met een functie  " + var);
        }
    }
}
