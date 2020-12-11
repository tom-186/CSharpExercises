using System;
using ExLINQ;


namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {   
            Console.WriteLine("Search city which name starts with letter:");
            string startLetter = Console.ReadLine(); 

            var result = FilteringUtils.Search(startLetter);               
            
            Console.WriteLine(result);
        }
    }
}