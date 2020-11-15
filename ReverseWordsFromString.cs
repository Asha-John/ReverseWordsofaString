using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace ReverseWordsFromString
{
    public class ReverseWords
    {
        public static void Main(String[] args)
        {
            Console.Write("Please Enter your main string : ");
            string mainstring = Console.ReadLine();
            string[] string_words = mainstring.Split(' ');
            string word = "";
            for (int i = string_words.Length - 1; i >= 0; i--) 
            {
               word += string_words[i] + " ";
            }
            Console.Write("Reversed String: " + word.Substring(0, word.Length - 1));
        }
    }
}