using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindromestring
{
    class Program
    {
        public static bool isPalindrome(string word)
        {
            //char[] letters = word.ToCharArray();
            string[] storeWords = new string[word.Length];
            string[] storeBackWOrds = new string[word.Length];

            string arrayToWords="", backWOrds="";

            for (int k = 0; k < word.Length; k++)
            {
                storeWords[k] = Convert.ToString(word[k]).Trim().ToLower();
                Console.WriteLine(storeWords[k].ToString());
                arrayToWords += String.Concat(storeWords[k]);

            }
            Console.WriteLine("\n");
            for (int j = word.Length - 1; j > -1; j--)
            {
                storeBackWOrds[j] = Convert.ToString(word[j]).Trim().ToLower();
                Console.WriteLine(storeBackWOrds[j].ToString());
                backWOrds+= String.Concat(storeWords[j]);
            }


           if(arrayToWords== backWOrds)
            {
                Console.WriteLine("{0} and {1} are palindrome", arrayToWords, backWOrds);
                return true;
            }
           else
            {
                Console.WriteLine("{0} and {1} are not palindrome", arrayToWords, backWOrds);
                return false;
            }

        }
        static void Main(string[] args)
        {
            string wordToCheck = Convert.ToString(Console.ReadLine());
            Console.WriteLine(Program.isPalindrome(wordToCheck));
            Console.ReadLine();
        }
    }
}
