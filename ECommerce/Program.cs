﻿using System;
using ECommerce;
using System.Collections.Generic;
using System.IO;

namespace CSharpExercises
{
    class Program
    {
          static void _Main(string[] args)
        {
            Customer firstCustomer = new Customer ("Francesco", "Rossi", 32, "frossi@yahoo.com");
            firstCustomer.Login();

            Customer secondCustomer = new Customer ("Andrea", "Bianchi", 15, "bandrea@gmail.com");
            secondCustomer.Login();

            Article article = new Article ("Face mask", 12.44, "No restrictions");
            Article article2 = new Article ("Bottle of wine", 25.85, "Not under 18");

            /* Issue #2 */
            
            int firstId = 4;
            article.RetrieveArticle(firstId);
            article.DestroyArticle(3);

            /* Issue #3 */
                        
            article2.OrderArticle(secondCustomer);  

            /* Issue #5 */

            var list = new Customers();

            list.Add(firstCustomer);
            list.Add(secondCustomer); 

            Console.WriteLine($"{list.CustomerList[0].FirstName} is the first customer");
            Console.WriteLine($"{list.CustomerList[1].FirstName} is the second customer");   
                                
        }

         public static void Main(string[] args)
        {
           // Milestone 1 
           Customer customer = new Customer ("First name", "Last name", 32, "email"); 
           Article article = new Article ("Article number one", 12.44, "No restrictions");
           Article article2 = new Article ("Article number two", 25.39, "No restrictions");
                    
           Articles.AddArticleToArticles(article);
           Articles.AddArticleToArticles(article2);

           Articles.GetListOfArticles();

           // Milestone 2
           var searchResult = Articles.Search("Article");

           Cart.AddToCart(searchResult);

           // Milestone 3
           Cart.TotalToPay(searchResult);

           var articleList = Articles.ArticleList;
           File.WriteAllText("list_of_articles", articleList[0].Description.ToString());                     

           }        

     }
}
