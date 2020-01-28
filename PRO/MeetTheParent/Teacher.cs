using System;

namespace AddAnInstance
{
    public class Teacher:Person
    {
        private string course;
        public Teacher(string name, string course, int awsomeness):base(name, awsomeness){
            this.course = course;
            Console.WriteLine("you teach " + course);
            }
        }
    }