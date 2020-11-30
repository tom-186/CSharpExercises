using System;

namespace ECommerce
{
    class Customer
    {
        // Fields or Attributes
        // Quanto più privati possibile
        protected int Id;
        protected string FirstName;
        protected string LastName;
        protected string Address;
        protected int Zip;
        protected string City;
        protected string EMail;
        protected string Password;
        
        // Properties
        // getter - setter
        // TODO
        public Customer(string firstName, string lastName, string eMail)
                {
                    // runs every time we call new on the class
                    // costruttore - inizializza
                    // this: this object created from
                    this.FirstName = firstName;
                    this.LastName = lastName;
                    this.EMail = eMail;
                }
        // visibilità - valore di ritorno - NomeMetodo()


        public void Login(){
            Console.WriteLine($"Hi, {this.FirstName} {this.LastName}, you are logged in..");
        }
        public void AddToCart(){
            Console.WriteLine("Product added to cart");
        }
        public void MyOrders(){
            Console.WriteLine("These are your orders");
        }
        public void WishList(){
            Console.WriteLine("This is your wishlist");
        }
        public void Cart(){
            Console.WriteLine("This is your cart");
        }
        public void Registration(){
            Console.WriteLine("You are registering");
        }
    }

    class Article{
        private int Id;
        private string Description;
        private double Price;
        private int Stock;
        private double Vat;

        public Article (string description, double price){
            this.Description = description;
            this.Price = price;
            }
        
        public void Create(){
            Console.WriteLine("You created an article");
        }

        public void Retrieve(int id){
            Console.WriteLine($"You are retrieving the {this.Description} article which costs {this.Price} and has {id} as Id");
        }

        public void Update(){
            Console.WriteLine("You updated an article");
        }

        public void Destroy(int id){
            Console.WriteLine($"You deleted the {this.Description} article which costs {this.Price} and has {id} as Id");
        }
    }
}