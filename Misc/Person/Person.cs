using System;
using System.IO;

namespace Person
{
    class Person
    {
        private string FirstName = "Gino";
        private string LastName = "Bianchi";
        private int Age;

        public Person(string firstName, string lastName, string age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            try
            { 
                var test = int.Parse(age);
                this.Age = test;
            }
            catch(FormatException err)
            {
                var logLine = $"{DateTime.Now} - {err.Message} - {err.StackTrace}\n"; 
                File.AppendAllText("error_log.log", logLine);
                
                Console.WriteLine(err.Message);
                Console.WriteLine("You must write a valid age format");
            }
        } 

        public void Save(string path)       
        {
            string personInfo = $"{FirstName}, {LastName}, {Age}\n";
            File.AppendAllText(path, personInfo);
        }

        public void Breath()
        {
            Console.WriteLine("I am breathing");
        }
        public void Fly()
        {
            Console.WriteLine("I am flying");
        }
    }

    class Brother : Person
    {
        private string FirstName;
        private string LastName;
        private string Age;
        public Brother(string firstName, string lastName, string age) : base (firstName, lastName, age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;            
        }

        public void BrotherFly()
        {
            base.Fly();
        }
    }
}