using System;

namespace AddAnInstance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Teacher t1 = new Teacher("Erwin", "PRO2", 5);
            Console.ForegroundColor = ConsoleColor.Red;
            Teacher t2 = new Teacher("Erik", "PRO2", 10);
            Console.ForegroundColor = ConsoleColor.Green;
            Teacher t3 = new Teacher("Theo", "PRO1", 9);
            Console.ForegroundColor = ConsoleColor.Red;
            Teacher t4 = new Teacher("Ed", "PRO1", 6);

            Console.ForegroundColor = ConsoleColor.Green;
            Student s1 = new Student("Harry", "Mediadeveloper", 4);
            Console.ForegroundColor = ConsoleColor.Red;
            Student s2 = new Student("Donny", "Gamedeveloper", 6);
            Console.ForegroundColor = ConsoleColor.Green;
            Student s3 = new Student("Calvin", "Gamedeveloper", 7);

            Console.ForegroundColor = ConsoleColor.Red;
            Parent p1 = new Parent("Linda", "Calvin", 10);
            Console.ForegroundColor = ConsoleColor.Green;
            Parent p2 = new Parent("Linda", "Calvin", 10);
            p2.parentOf = "Emile";

            Console.ResetColor();
        }
    }
}
