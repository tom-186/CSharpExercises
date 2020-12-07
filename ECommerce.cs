using System;

namespace ECommerce
{
    class Customer
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
        
        // Properties
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

        // Properties
        public Article (string description, double price, string restricted)
        {
            this.Description = description;
            this.Price = price;
            this.Restrictions = restricted;
        }
        
        // Methods
        public void Create()
        {
            Console.WriteLine("You created an article");
        }

        public void Retrieve(int id)
        {
            Console.WriteLine($"You are retrieving the {this.Description} article which costs {this.Price} and has {id} as Id");
        }

        public void Update()
        {
            Console.WriteLine("You updated an article");
        }

        public void Destroy(int id)
        {
            Console.WriteLine($"You deleted the {this.Description} article which costs {this.Price} and has {id} as Id");
        }

 
        public void Order(Customer customer){           
                 

             if (customer.Age < 18 && this.Restrictions == "Not under 18")
             {
                 Console.WriteLine($"Sorry, you can not buy {this.Description} because you are {customer.Age} years old");
             }
             else
             {        
                 Console.WriteLine($"You made an order for this article");
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
        public void Create()
        {
            Console.WriteLine("You created an article");
        }

        public void Destroy()
        {
            Console.WriteLine($"You deleted the {this.Description} article");
        }

        public void List()
        {
            Console.WriteLine("This is the list of your order headers");
        }        
        
    }
  }
}