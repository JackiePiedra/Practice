﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Stuff
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's count the vowels.. Enter a phrase of any length:");
            string userPhrase = Console.ReadLine().ToLower();

            string vowelList = "aeiou";
            int vowelCount = 0;
            for (int i = 0; i<userPhrase.Length; i++)
            {
                if (vowelList.Contains(userPhrase[i]))
                {
                    vowelCount++;
                }
            }

            Console.WriteLine("There are " + vowelCount + " vowels in your phrase.");
            Console.ReadLine();



        }
    }
}