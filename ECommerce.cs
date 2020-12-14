using System;
using System.Collections.Generic;
using System.Linq;


namespace ECommerce
{
    class Customer : User
    {
        // Fields 
        public int Id { get; set; }
        public string FirstName { get; }
        public string LastName { get;  }
        public int Age { get; }
        public string Address { get; }
        public int Zip { get; }
        public string City { get;}
        public string Email { get; }
        public string Password { get; }
        
        // Constructor
        public Customer(string firstName, string lastName, int age, string email)
                {
                    this.FirstName = firstName;
                    this.LastName = lastName;
                    this.Email = email;
                    this.Age = age;
                }
        
        // Methods

        public void Login()
        {
            Console.WriteLine($"Hi, {this.FirstName} {this.LastName}, age {this.Age}, you are logged in..");
        }
        public void AddToCart()
        {
            Console.WriteLine("Product added to cart");
        }
        public void MyOrders()
        {
            Console.WriteLine("These are your orders");
        }
        public void WishList()
        {
            Console.WriteLine("This is your wishlist");
        }
        public void Cart()
        {
            Console.WriteLine("This is your cart");
        }
        public void Registration()
        {
            Console.WriteLine("You are registering");
        }
     }  

    class Admin : User
    {
        // Fields 
        public int Id { get; set; }
        public string FirstName { get; }
        public string LastName { get;  }
        public string Administrator {get; }
        public string Email { get; }
        public string Password { get; }

        // Constructor
        public Admin(string firstName, string lastName, string email)
                {
                    this.FirstName = firstName;
                    this.LastName = lastName;
                    this.Email = email;
                }

        // Methods
        public void Login()
        {
            Console.WriteLine($"Hi, {this.FirstName} {this.LastName}, you are logged in..");
        }

        public void ManageOrders()
        {
            Console.WriteLine("You can now manage orders");
        }

        public void ManageArticles()
        {
            Console.WriteLine("You can now manage articles");
        }

        public void ManageCustomers()
        {
            Console.WriteLine("You can now manage cutomers");
        }
    } 

    class User
    {
            // to be completed
    }  
    
    class Article
    {
        // Fields
        public int Id { get; }
        public string Description { get; }
        public double Price { get; set; }
        public int Stock { get; }
        public string Sku  { get; } 
        public double Vat { get; set; }
        public string Restrictions { get; set; }

        // Constructor
        public Article (string description, double price, string restricted)
        {
            this.Description = description;
            this.Price = price;
            this.Restrictions = restricted;
        }
        
        // Methods
        public void CreateArticle()
        {
            Console.WriteLine("You created an article");
        }

        public void RetrieveArticle(int id)
        {
            Console.WriteLine($"You are retrieving the {this.Description} article which costs {this.Price} and has {id} as Id");
        }

        public void Update()
        {
            Console.WriteLine("You updated an article");
        }

        public void DestroyArticle(int id)
        {
            Console.WriteLine($"You deleted the {this.Description} article which costs {this.Price} and has {id} as Id");
        }

 
        public void OrderArticle(Customer customer)
        {       

             if (customer.Age < 18 && this.Restrictions == "Not under 18")
             {
                 Console.WriteLine($"Sorry, you can not buy {this.Description} because you are {customer.Age} years old");
             }
             else
             {        
                 Console.WriteLine($"You made an order for this article");
             }
        }
    } 
  
        

    class OrderHeader
    {
        //Fields
        private int Id;
        private int OrderNumber; 
        private DateTime Date;
        private int UserId;

        //Methods
        public void CreateOrder()
        {
            Console.WriteLine("You created an article");
        }

        public void DestroyOrder()
        {
            Console.WriteLine("You deleted the this article");
        }

        public void ListOrder()
        {
            Console.WriteLine("This is the list of your order headers");
        }        
        
    }

          class Customers
    {
        //Fields
        public List<Customer> CustomerList = new List<Customer>();
        
        // Constructor
        public Customers()
        {
            this.CustomerList = new List<Customer>();
        }

        //Methods
         public void Add(Customer customer)
        {
            this.CustomerList.Add(customer);
        }  
        
    }  

    class OrderDetail
    {
        // Fields
        private int Id;
        private int Id_order;
        private int Id_article;
        private double Price;
        private int Qta;
    }

    class Articles
    {
        //Fields
        public static List<Article> ArticleList = new List<Article>();

        //Methods
        public static void AddArticleToArticles(Article newArticle)
        {
            //Method to add an article to the list of articles
            ArticleList.Add(newArticle);
            Console.WriteLine($"You added an article to the list of articles");
        }

        public static void GetListOfArticles()
        {
            //Method to get the list of articles
            Console.WriteLine($"You have requested the list of articles, which contains {ArticleList.Count} elements:");
            foreach (var item in ArticleList)
            {
                Console.WriteLine(item.Description);
            }
        }

        public static void Search(string searchTerm)
        {
            IEnumerable<string> searchQuery =
            from element in ArticleList
            where element.Contains(searchTerm)
            select element;

            Console.WriteLine($"You searched for term {searchTerm}; this article, {element}, which costs{element.Price} would be suitable for you?");

        }
    }

    class Cart
    {
        // Fields
        private int Id;
        private int Id_article;
        private int UserId;
        private int Qta;

        //Methods
        public void Buy()
        {
            Console.WriteLine("You will soon redirected to the payment page");
        }

        public void Empty()
        {
            Console.WriteLine("You removed all articles from cart");
        }

        public void ListCart()
        {
            Console.WriteLine("This is the list of your carts");
        } 
    }

 
}
