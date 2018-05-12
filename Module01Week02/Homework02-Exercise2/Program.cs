using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework02_Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            String word;
            String wordToCompare = "PentaStagiu";

            Console.WriteLine("Word: ");
            word = Console.ReadLine();

            //Returns 0 for true and 1 for false
            if(word.CompareTo(wordToCompare)==1)
               Console.WriteLine("Words don't match");
            else
                Console.WriteLine("Same word");

            //Check whether 'a' exists or not in string
            Console.WriteLine("Is 'a' in the word? " + word.Contains("a"));

            //Returns HashCode of String
            Console.WriteLine("Hashcode: " + word.GetHashCode());

            //Returns the first index position of specified value
            Console.WriteLine("First position of letter n: " + word.IndexOf("n"));

            //Returns the Length of String
            Console.WriteLine("Word lenght: " + word.Length);

            //Returns substring
            Console.WriteLine("Substring: " + word.Substring(5, 6));
 
            //Split the string based on specified value
            Console.WriteLine("Split");
            string[] split = word.Split(new char[] { 'a' });
            Console.WriteLine(split[0]);
            Console.WriteLine(split[1]);

            Console.ReadLine();


        }
    }
}
