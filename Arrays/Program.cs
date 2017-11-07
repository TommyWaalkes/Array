﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main()
        {
            //You can fill an array on one line
            int[] nums = { 1, 34, 66, 85, 12, 22 };
            int num = nums[2];
            Console.WriteLine(num);
            string[] names = new string[] { "Tammy", "Billy", "Joey", "Mikey", "Ice T","Phil" };
            Console.WriteLine("For loop Starting!");
            for(int i = 0; i<names.Length; i++)
            {
                string name = names[i];
                Console.WriteLine(name);
            }
            Console.WriteLine("For Loop Done!");

            Console.WriteLine(names.Contains("Tommy"));


            Console.WriteLine();
            //If you don't know what you're going to put in 
            //NOTE: Arrays must have a set length when you make them 
            //It goes in the brackets after the datatype
            //Arrays CANNOT shrink or grow
            string[] cities = new string[5];
          
            for(int i = 0; i<cities.Length; i++)
            {
                Console.WriteLine("Please enter a city name for index " + i);
               // cities[i] = Console.ReadLine();
            }
            //What happens if I refer to an index with no value in it?
            for(int i = 0; i<cities.Length; i++)
            {
                //Console.WriteLine("City Number " +i+" is " +cities[i]);
            }

            Console.WriteLine();


            Console.WriteLine("For Each Loop Start!");
            //Foreach loop example 
            //Think of it verbally 
            //For item in my collection 
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine(names);
            Console.WriteLine("For Each Loop Done!");
        }
    }
}
