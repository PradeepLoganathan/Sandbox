using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            foreach(string s in args)
                Palindrome2(s);
        }

        static void Palindrome1(string input)
        {
            string rev = null;
            int i;

            input.ToLower();
            for(i = input.Length - 1; i >= 0; i--)
            {
                rev += input[i];
            }

            if(rev == input)
                Console.WriteLine("Palindrome1 - Input is a Palindrome");
            else
                Console.WriteLine("Palindrome1 - Input is not a palindrome");
        }

        static void Palindrome2(string input)
        {
            if(input.ToLower() == input.Reverse().ToLower())
                 Console.WriteLine("Palindrome2 - {0} is a Palindrome", input);
            else
                Console.WriteLine("Palindrome2 - {0} is not a palindrome", input);
        }
       
    }

    static class stringextension
    {
        public static string Reverse(this string st)
        {
            string revstring = null;
            for(int i = st.Length - 1; i >= 0; i--)
            {
                revstring += st[i];
            }

            return revstring;
        }
    }
}
