using System;
using ECommerce;

namespace CSharpExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Insert your name:");
            string myName = Console.ReadLine();
            Console.WriteLine(myName.ToUpper()); */

            // var firstCustomer = new Customer();
            Customer firstCustomer = new Customer ("Francesco", "Rossi", 32, "frossi@yahoo.com");
            firstCustomer.Login();

            Customer secondCustomer = new Customer ("Andrea", "Bianchi", 15, "bfran@gmail.com");
            secondCustomer.Login();

            Article article = new Article ("Face mask", 12.44, false);
            Article article2 = new Article ("Bottle of wine", 25.85, true);

            /* Issue #2 */
            
            int firstId = 4;
            article.Retrieve(firstId);
            article.Destroy(3);

            /* Issue #3*/

            Console.WriteLine(article2.NotUnder18);

            
            article2.Order(secondCustomer);       

                   
        }
    }
}
