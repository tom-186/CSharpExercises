using System.Linq;
using System.Collections.Generic;

namespace ExLINQ
{
    class FilteringUtils
    {   
        // Methods
        public static string Search(string startLetter)
        {
            var cities = new string[]{"Arezzo", "Arezzo", "Siena", "Firenze", "Lucca"};

            IEnumerable<string> query =
            from city in cities
            where city[0] == startLetter[0]
            select city;
            
            return query.First();
                     
        } 
    }

    class Mountains
    {
        // Methods
        public static string[] ListOfMountains(string startingString)
        {
            string[] mountains = startingString.Split(';');
            return mountains;                    
        }
    }
}