using System;
using System.Collections.Generic;
using System.Text;

namespace PigLatin
{
    class Convert
    {
        //fields
        private string _word;

        //properties
        public string Word
        {
            get { return this._word; }
            set { this._word = value; }
        }

        //Constructor

        public Convert(string word)
        {
            this._word = word;
        }

        //methods
        public bool IsVowel(char c)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            foreach (char letter in vowels) //I made foreach loop because need to check each letter in vowels
            {

                if (letter == c)
                {
                    return true;
                }
            }
            
            //return (c.ToString() == vowels.ToString());//checking the whole array so never turns to true
            return false;
        }

       
        public  string ToPigLatin(string word)
        {
            char[] specialChars = { '@', '.', '-', '$', '^', '&' };
            word = word.ToLower();
            foreach (char c in specialChars)
            {
                foreach (char w in word)
                {
                    if (w == c)
                    {
                        //It's not looking good if it's comming in the console
                        //Console.WriteLine("That word has special characters, we will return it as is");
                        return word;
                    }
                }

            }
            //To print the no vowel word as it is , Eg: gym as gym
            bool noVowels = true;
            foreach (char letter in word)
            {
                if (IsVowel(letter))
                {
                    noVowels = false;
                }
            }

            if (noVowels)
            {
                return word;
            }

            //Eg:change the word heck to eckhay
            char firstLetter = word[0];
            string output = "placeholder";
            if (IsVowel(firstLetter) == true)
            {
                output = word + "ay";
            }
            else
            {
                int vowelIndex = -1;
                //Handle going through all the consonants
                for (int i = 0; i <= word.Length; i++)
                {
                    if (IsVowel(word[i]) != true)
                    {
                        vowelIndex = i;
                        break;
                    }
                }                

                //This statement will give the substring of the word except the first letter
                string sub = word.Substring(vowelIndex + 1);
                //To get the first letter. I added the vowelIndex by 1
                string postFix = word.Substring(0, vowelIndex + 1);

                output = sub + postFix + "ay";
            }

            return output;
        }


        //I tried this way too. I didn't call it in the main
        public string ToPigLatinDifferent(string word)
        {
            char[] specialChars = { '@', '.', '-', '$', '^', '&' };//checking the special characters
            word = word.ToLower();
            foreach (char c in specialChars)
            {
                foreach (char w in word)
                {
                    if (w == c)
                    {
                        //It's not looking good if it's comming in the console
                        //Console.WriteLine("That word has special characters, we will return it as is");
                        return word;
                    }
                }

            }



            char firstLetter = word[0];
            string output = "placeholder";
            if (IsVowel(firstLetter) == true)
            {
                output = word + "ay";

            }



            else
            {
                string sub1 = word.Substring(1); //it gives the other letters except the first letter           


                output = sub1 + firstLetter + "ay";
            }


            return output;
        }


    }
}
