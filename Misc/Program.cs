﻿using System;
using ExLINQ;


namespace Program
{
    class Program
    {
        static void Main (string[] args)
        {
            Peaks.FirstColumn(";","Monte Falco, 1658, Parco Foreste Casentinesi ; Monte Falterona, 1654, Parco Foreste Casentinesi; Monte Fumaiolo, 1407, Appennino Tosco Emiliano");
        }

        public static void _Main(string[] args)
        {   
            var result = FilteringUtils.Search("S");     // insert here which letter is to be searched         
            Console.WriteLine(result);

            var startingString = "Monte Falco, 1658, Parco Foreste Casentinesi ; Monte Falterona, 1654, Parco Foreste Casentinesi; Monte Fumaiolo, 1407, Appennino Tosco Emiliano";
            var result2 = Mountains.ListOfMountains(startingString);  // less code here, only methods
            foreach (var item in result2)
            {
               Console.WriteLine(item.Split(',')[0].Trim()); 
            }            

        }
    }
}