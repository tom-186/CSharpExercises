using System;
using ECommerce;

namespace CSharpExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer firstCustomer = new Customer ("Francesco", "Rossi", 32, "frossi@yahoo.com");
            firstCustomer.Login();

            Customer secondCustomer = new Customer ("Andrea", "Bianchi", 15, "bandrea@gmail.com");
            secondCustomer.Login();

            Article article = new Article ("Face mask", 12.44, "No restrictions");
            Article article2 = new Article ("Bottle of wine", 25.85, "Not under 18");

            /* Issue #2 */
            
            int firstId = 4;
            article.Retrieve(firstId);
            article.Destroy(3);

            /* Issue #3*/

                        
            article2.Order(secondCustomer);       

                   
        }
    }
}
