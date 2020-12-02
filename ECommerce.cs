using System;

namespace ECommerce
{
    class Customer
    {
        // Fields or Attributes
        // Quanto più privati possibile
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public int Zip { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        
        // Properties
        // getter - setter
        // TODO
        public Customer(string firstName, string lastName, int age, string email)
                {
                    // runs every time we call new on the class
                    // costruttore - inizializza
                    // this: this object created from
                    this.FirstName = firstName;
                    this.LastName = lastName;
                    this.Email = email;
                    this.Age = age;
                }
        // visibilità - valore di ritorno - NomeMetodo()


        public void Login(){
            Console.WriteLine($"Hi, {this.FirstName} {this.LastName}, age {this.Age}, you are logged in..");
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

        public int Id { get; }
        public string Description { get; }
        public double Price { get; set; }
        public int Stock { get; }
        public string Sku  { get; }  // per alcuni ecommerce la giacenza è il codice del prodotto
        public double Vat { get; set; }
        public string Restricted { get; set; }

        // Costruttore
        public Article (string description, double price, string restricted){
            this.Description = description;
            this.Price = price;
            this.Restricted = restricted;
            }
        // Metodi
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


 
        public void Order(Customer customer){           
                 

             if (customer.Age < 18 && this.Restricted == "Not Under 18")
             {
                 Console.WriteLine($"Sorry, you can not buy this article");
             }
             else
             {        
                 Console.WriteLine($"You made an order for the article");
             }
        } 
  
        

    class OrderHeader{
        private int Id; // in automatico
        private int OrderNumber; // in automatico
        private DateTime Date;
        private int UserId; //BIGINT - serial (in altri DB)

        //Costruttore
        public OrderHeader(int userId, DateTime date){
            UserId = userId;  // non è obbligatorio il this.
            Date = date;
        }
    }
  }
}