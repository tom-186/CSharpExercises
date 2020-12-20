using System;
using System. Collections.Generic;
using System.Linq;
using System.IO;

namespace exercise_Linq
{
    class Program
    {
        public static void Main(string[] args)
        {
            /* var prices = new List<Article>{};
                                 
            Article article1 = new Article(4.35,"t-shirt");
            Article article2 = new Article(58.39, "jeans");

            prices.Add(article1);
            prices.Add(article2);

            Console.WriteLine(prices[1].Description); 
            
            var total = prices.Aggregate(0.00, (acc, val) => acc + val.Price);
            Console.WriteLine(total); */

            IEnumerable<string> lines = File.ReadAllLines("order-details.csv");
            var query =
            from line in lines
            let row = line.Split(",")
            let fourthColumn = row[3]
            select int.Parse(fourthColumn);
            
            Console.WriteLine(query.Sum());

            var max = query.Max();

            Console.WriteLine(max);

            File.WriteAllText("max.text", max.ToString());            
        }         
    }

    /* class Article
    {
        public double Price {get;} = 45.50;        
        public string Description = "Description example";

        public Article(double price, string description)
        {
            this.Price = price;
            this.Description = description;
        }
    } */
}
