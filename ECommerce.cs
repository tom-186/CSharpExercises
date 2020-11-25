namespace ECommerce
{
    class Customer
    {
        protected int Id;
        protected string Name;
        protected string Surname;
        protected string Address;
        protected int Zip;
        protected string City;
        protected string Email;
        protected string Password;
        
        //
        // visibilità - valore di ritorno - NomeMetodo()


        public void Login(){
            Console.WriteLine("You are logged in..");
        };
        public void Buy(){
            Console.WriteLine("You are buying...");
        };
        public void MyOrders(){
            Console.WriteLine("These are your orders");
        };
        public void WishList(){
            Console.WriteLine("This is your wishlist");
        };
        public void Cart(){
            Console.WriteLine("This is your cart");
        };
        public void Registration(){
            Console.WriteLine("You are registering");
        };
    }
}