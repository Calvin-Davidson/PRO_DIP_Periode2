using System;

namespace AddAnInstance
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher t1 = new Teacher("Erwin", "PRO2");
            Teacher t2 = new Teacher("Erik", "PRO2");
            Teacher t3 = new Teacher("Theo", "PRO1");
            Teacher t4 = new Teacher("Ed", "PRO1");

            Student s1 = new Student("Harry", "Mediadeveloper");
            Student s2 = new Student("Donny", "Gamedeveloper");
            Student s3 = new Student("Calvin", "Gamedeveloper");

            Parent p1 = new Parent("Linda", "Vrouw");
            Parent p2 = new Parent("Marco", "Man");
        }
    }
}
