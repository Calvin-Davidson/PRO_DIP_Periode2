using System;

namespace SimpelCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wat wil je berekenen?");
            Console.WriteLine("Je kan kiezen uit, optellen, aftrekken, vermenigvuldigen, delen, modulo");
            string input = Console.ReadLine();

            args = input.Split(" ");
            if (args[0] == "stop") { return; }
            Console.WriteLine(calculator(Convert.ToInt32(args[0]), args[1], Convert.ToInt32(args[2])));


            while(true) {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Wil je nog wat bereken?");
            Console.WriteLine("Je kan kiezen uit, optellen, aftrekken, vermenigvuldigen, delen, modulo");
            input = Console.ReadLine();

            args = input.Split(" ");
            if (args[0] == "stop") { return; }
            Console.WriteLine(calculator(Convert.ToInt32(args[0]), args[1], Convert.ToInt32(args[2])));
            System.Threading.Thread.Sleep(1000);
            }

            int calculator(int numberOne, string type, int numberTwo) {
                int answer = 0;
                switch(type) {
                    case "optellen":
                    answer = numberOne + numberTwo;
                    break;
                    case "aftrekken":
                    answer = numberOne - numberTwo;
                    break;
                    case "vermenigvuldigen":
                    answer = numberOne * numberTwo;
                    break;
                    case "delen":
                    answer = numberOne / numberTwo;
                    break;
                    case "modulo":
                    answer = numberOne % numberTwo;
                    break;
                }
                return answer;
            }
        }
    }
}
