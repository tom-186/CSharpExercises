using System;
using Person;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {            
            Person person = new Person(args[0] , args[1] , args[2]);
            person.Save("list_of_people.csv");
            
            Brother sam = new Brother("Sam", "White", "19");
            sam.Fly();

        }
    }
}
