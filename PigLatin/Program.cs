using System;
using System.Collections.Generic;
using System.Linq;

namespace PigLatin
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool runProgram = true;
            while (runProgram)
            {
                string userInput = GetInput("Please input a word or sentence to translate to pig Latin");
                string[] wordInput = userInput.Split(" ");
                List<string> convertedLine = new List<string>();//making a list to store the translated words

                for (int i = 0; i < wordInput.Length; i++)
                {
                    Convert convert = new Convert(wordInput[i]);
                    string translation = convert.ToPigLatin(wordInput[i]);
                    convertedLine.Add(translation);


                }
                for (int i = 0; i < convertedLine.Count; i++)//to print the list
                {
                    Console.Write($"{ convertedLine[i]  }  ");

                }

                while (true)
                {
                    Console.WriteLine("\nDo you want to continue?y/n");
                    string choice = Console.ReadLine().Trim().ToLower();
                    if (choice == "y")
                    {
                        break;
                    }
                    else if (choice == "n")
                    {
                        runProgram = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("wrong input. Please try again");
                    }
                }
            }
            

        }
        //method to get input
        public static string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine().ToLower().Trim();
            return input;
        }  

        

            
            
    }
}
