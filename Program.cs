﻿using System;
namespace Search
{
    class Search
    {
        static void Main(string[] args)
        {

            string[] students = { "Christian", "Michael", "Camila", "Sienna", "Tanya", "Connor", "Zachariah", "Mallory", "Zoe", "Emily" };
            Console.WriteLine("Enter a name’s student:");
            string input_name = Console.ReadLine();
            bool isExist = false;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Equals(input_name))
                {Console.WriteLine ("Found !");
                    Console.WriteLine("Position of the students in the list  [" + input_name + " ] is: " + i);
                    isExist = true;
                    break;
                }
            }
            if (!isExist)
            {
                Console.WriteLine("Not found   [ " + input_name + " ]   in the list.");
            }

        }

    }
}