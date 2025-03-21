using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCAD17MenteeGroup
{
    public class Palindrome
    {
        // RACECAR
        // OTTO
        // LEVEL
        // O11O
        // 121
        // Start from two points. Front of string and back of string and make comparisions O(n^2)
        // Generate a reversed string and compare to original O(n)
        public static bool IsPalindromeHakim(string mystring)
        {
            // Mohaimen
            // nemiahoM
            // OTTO
            // OTTO
            return false;
        }


        public static bool IsPalindromeJosh(string mystring) // OTTO
        {
            StringBuilder sb = new StringBuilder(); // sb = []
            for (int i = mystring.Length - 1; i >= 0; i--)
            {
                sb.Append(mystring[i]); // sb= [O,T,T,O]
            }
            // OTTO == OTTO
            if (sb.ToString() == mystring)
            {
                return true;
            }
            return false;
        }
            // second solution (nerd)
            public static bool IsPalidromeJosh2(string mystring)
        {


            int j = 0;
            int k = mystring.Length - 1;
            while (j < k)
            {
                if (mystring[j] != mystring[k])
                {
                    return false;

                    j++;
                    k--;
                }
            }
            return true;
        }

        public static bool IsPalindromeSadiki(string mystring)
        {
            string reversed = new string(mystring.Reverse().ToArray());
            return string.Equals(mystring, reversed, StringComparison.OrdinalIgnoreCase);


        }

        public static bool IsPalinromeIke(string mystring)
        {
            int e = mystring.Length;
            
            for (int i = 0; i < mystring.Length; i++)
            {
                if(mystring[i] != mystring[e])
                {
                    return false;
                }
                e--;
            }
            return true;
        }

        
    }
}
