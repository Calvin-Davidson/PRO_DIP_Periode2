using System;

namespace AddAnInstance
{
    public class Person
    {
        public string name = "no_name";
        public Person(string name){
            //constructor
            this.name = name;

            Console.WriteLine("Hi there "+name);
        }
        
    }
}