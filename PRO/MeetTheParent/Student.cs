using System;

namespace AddAnInstance
{
    public class Student : Person{
        public Student(string name, string education, int awsomeness) : base(name, awsomeness){
            //constructor
            Console.WriteLine(" You're studying "+education);
        }
    }
}