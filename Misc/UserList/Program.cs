using System;
using System.Collections.Generic;
using Users;
using System.IO;


namespace Users
{
    class Program
    {
        static void Main(string[] args)
        {            
            User firstUser = new User();
            firstUser.Age = 57; 
            firstUser.name = "Mario"; 

            User secondUser = new User();
            secondUser.Age = 25; 
            secondUser.name = "Andrea"; 

            var list = new UserList();
            list.Add(firstUser);
            list.Add(secondUser);

            var result = UserList.Extract("a");

            foreach (var person in result)
            {
            File.AppendAllText("people.txt", person.name + Environment.NewLine);
            }

                                    
        }
    }
}
