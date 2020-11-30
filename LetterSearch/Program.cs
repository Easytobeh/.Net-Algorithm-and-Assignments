using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get string

            
            Console.WriteLine("Welcome, please choose mode:\n" +
                "1 --> Case Sensitive Mode\n" +
                "2 --> Not Case Sensitive");
            string mode = Console.ReadLine();
            Console.WriteLine($"You have selected mode: {mode}");

            Console.Write("Enter a string: ");
            string word = Console.ReadLine();
            Console.WriteLine($"You typed {word}");

            //confirm if string is not empty
            if (String.IsNullOrEmpty(word))
                Console.WriteLine("Empty String");
         
            else
            {
                if (mode == "1")
                    CaseSensitiveMode(word);
                else if (mode == "2")
                    NoCaseMode(word);
                else
                    Console.WriteLine($"Mode {mode} is not defined");

            }

        }
        static void CaseSensitiveMode(string thisWord)
        {
           
            if(thisWord.StartsWith("Sa"))
                Console.WriteLine("The String starts with \"Sa\"");
            else
                Console.WriteLine("String doesn't begin with \"Sa\"");

            //count the characters in word
            checkLetter(thisWord);

        }

        static void NoCaseMode(string thisWord)
        {
            //thisWord.ToLower();

            if (thisWord.ToLower().StartsWith("sa"))
                Console.WriteLine("The String begins with \"sa\"");
            else
                Console.WriteLine("String doesn't begin with \"sa\"");
            //Count characters in the word
            checkLetter(thisWord);
        }

        static void checkLetter(string thisWord)
        {
            Console.WriteLine(thisWord[1]);
            int count = 0;
            for (int index = 0; index < thisWord.Length; index++)
            {
                if (thisWord[index] == 'e' || thisWord[index] == 'm')
                    continue;
                else
                    count++;

            }
            Console.WriteLine($"The Word contains {count} number of characters other than 'm' and 'e'");
        }
    }
}
