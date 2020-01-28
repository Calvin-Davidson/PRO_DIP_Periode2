using System;

namespace AddAnInstance
{
    public class Person
    {
        public string _name = "no_name";
        private int _awsomeness = 0;
        public Person(string name, int awsomeness){
            //constructor
            this._name = name;
            this._awsomeness = awsomeness;

            Console.WriteLine("Hi there "+ _name + ", you have an awsomeness of " + _awsomeness);
        }
    }
}