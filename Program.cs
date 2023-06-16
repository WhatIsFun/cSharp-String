using System.ComponentModel;
using System.Diagnostics.Tracing;

namespace cSharp_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string hello = "Hello"; 
            string reversed = "";
            Console.WriteLine("The reverse of " + hello + " is " + (reverseString(reversed, hello)));*/

            /*int vowelTotal = 0;
            var vowel = new HashSet<char> { 'a', 'o', 'i', 'u', 'e' }; 
            Console.WriteLine("Enter a string to count the vowel>>> ");
            string word = Console.ReadLine();
            Console.WriteLine("Your total number of vowel in " + word + " is "+ vowelCounter(vowelTotal, word));*/


            //Console.WriteLine("Enter a sentence to reversed >>> ");
            //string sentence = Console.ReadLine();
            //string reverseSen = " ";
            //Console.WriteLine("Your reversed sentence of " + sentence + " is "+ reverseSentence(reverseSen, sentence));

            Console.WriteLine("Enter a sentence to reversed >>> ");
            string sentence = Console.ReadLine();
            string replacementSen = " ";
            Console.WriteLine("Which letter want to replace in the sentence >>> ");
            char tLetter = Convert.ToChar(Console.ReadLine()); // Target letter
            Console.WriteLine("Enter the letter to replace in the sentence >>> ");
            char rLetter = Convert.ToChar(Console.ReadLine()); // Replacement letter 
            Console.WriteLine("The sentence after the replacement: " + replacementcharacter(sentence, rLetter, tLetter, replacementSen));
        }



        //Write a function that takes a string as input and returns the reverse of that string. For example, if the input is "Hello", the function should return "olleH". Without using the built-in functions
        //static string reverseString(string reversed, string hello)
        //{

        //    // Loop through the input string from the end to the beginning
        //    for (int i = hello.Length - 1; i >= 0; i--)
        //    {
        //        // Append each character to the reversed string
        //        reversed += hello[i];
        //    }
        //    //Console.WriteLine(reversed); //Test the output

        //    // Return the reversed string
        //    return reversed;
        //}

        //Write a function that takes a string as input and counts the number of vowels (a, e, i, o, u) present in the string. For example, if the input is "Open", the function should return 2.
        //static int vowelCounter(int vowelTotal, string word)
        //{
        //    var vowel = new HashSet<char> { 'a', 'o', 'i', 'u', 'e' };// Vowel collections
        //    for (int i = 0; i < word.Length; i++) { //i = char
        //        if (vowel.Contains(word[i]))
        //        {
        //            vowelTotal++; // Vowel count
        //        }
        //    }
        //    return vowelTotal;
        //}

        //Write a function that takes a sentence as input and reverses the order of the words. For example, if the input is "Hello World", the function should return "World Hello".
        //static string reverseSentence(string sentence, string reverseSen)
        //{
        //    string[] words = sentence.Split(' ');
        //    Array.Reverse(words);
        //    reverseSen = String.Join(' ', words);
        //    return reverseSen;
        //}

        //Write a function that takes a string, a target character, and a
        //replacement character as inputs. The function should replace all
        //occurrences of the target character with the replacement character
        //in the string. For example, if the input string is "Hello World",
        //the target character is 'o', and the replacement character is 'a',
        //the function should return "Hella Warld".

        static string replacementcharacter(string sentence, char rLetter,char tLetter, string replacementSen)
        {
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == tLetter)
                {
                    replacementSen += rLetter;
                }
                else
                {
                    replacementSen += sentence[i];
                }
            }
            return replacementSen;
        }

        //Write a function that takes a string as input and checks if it is a palindrome
        //(reads the same forwards and backwards). The function should return true if the
        //string is a palindrome and false otherwise.For example, if the input is "level",
        //the function should return true.
        //static string PalindromeCheck(string sentence)
        //{

        //}
    }
}