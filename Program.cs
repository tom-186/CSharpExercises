using System;
using ECommerce;

namespace CSharpExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Insert your name:");
            string string1 = Console.ReadLine();
            Console.WriteLine(string1.ToUpper()); */

            // var firstCustomer = new Customer();
            Customer firstCustomer = new Customer ("Francesco", "Rossi", "frossi@yahoo.com");
            firstCustomer.Login();

            Customer secondCustomer = new Customer ("Andrea", "Bianchi", "bfran@gmail.com");
            secondCustomer.Login();

            Article article = new Article ("Face mask", 12.44);

            int firstId = 4;
            article.Retrieve(firstId);
            article.Destroy(3);
        
        }
    }
}
