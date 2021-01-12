using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Users
{

    class User
    {
        private int age;
        public string name; 
        public int Age   
        {           
            set
            {
                if (value>17)
                {
                    age = value;                    
                    Console.WriteLine($"You changed user age, that is currently {value}");
                }
                else
                {
                    Console.WriteLine("Sorry, you can't change age");
                }
                
            }   
        }

        
    }

     class UserList
    {
         //Fields
        public static List<User> allUsers = new List<User>();
        
        // Constructor
        public UserList()
        {
            allUsers = new List<User>();
        }

        //Methods
         public void Add(User user)
        {
            allUsers.Add(user);
            Console.WriteLine($"The User list now contains {allUsers.Count} element(s):");
        }

        public static List<User> Extract(string letter)
        {
            IEnumerable<User> searchQuery =
            from element in allUsers
            let name = element.name
            where name.Contains(letter)
            select element; 

            List<User> resultList = searchQuery.ToList<User>();
           
            
            Console.WriteLine($"You searched for letter '{letter}', these are your results: ");

            foreach (var item in resultList)
            {
              Console.WriteLine($"{item.name}");
            } 
            return resultList;

        }       

    } 

}
