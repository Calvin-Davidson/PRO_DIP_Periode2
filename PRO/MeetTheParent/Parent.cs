using System;

namespace AddAnInstance
{
    class Parent : Person
    {
        private string _parentOf;

        // die : base() < = verwijst naar de constuctor van Person
        public Parent(string name, string parentOf, int awsomeness) : base (name, awsomeness) {
            this._parentOf = parentOf;
            Console.WriteLine("Ouder van: " + _parentOf);
        }


        public string parentOf {
            get { return this._parentOf; }
            set { this._parentOf = value; 
            Console.WriteLine("Nu ben ik de parent van " + value);
            }
        }
    }
    }
