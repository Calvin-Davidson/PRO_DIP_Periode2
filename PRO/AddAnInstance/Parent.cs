using System;

namespace AddAnInstance
{
    class Parent : Person
    {
        private string gender;
        public Parent(string name, string gender) {
            this.name = name;
            this.gender = gender;
            Console.WriteLine("Gender is: " + gender);
        }
    }
    }
