using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            foreach (string s in args)
                Palindrome2(s);
        }

        static void Palindrome1(string input)
        {
            string rev = null;
            int i;

            input.ToLower();
            for (i = input.Length - 1; i >= 0; i--)
            {
                rev += input[i];
            }

            if (rev == input)
                Console.WriteLine("Palindrome1 - Input is a Palindrome");
            else
                Console.WriteLine("Palindrome1 - Input is not a palindrome");
        }

        static void Palindrome2(string input)
        {
            if (input.ToLower() == input.Reverse().ToLower())
                Console.WriteLine("Palindrome2 - {0} is a Palindrome", input);
            else
                Console.WriteLine("Palindrome2 - {0} is not a palindrome", input);
        }

        public static bool isPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 2; i <= boundary; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

    }

    static class stringextension
    {
        public static string Reverse(this string st)
        {
            string revstring = null;
            for (int i = st.Length - 1; i >= 0; i--)
            {
                revstring += st[i];
            }

            return revstring;
        }
    }

    public class URLShortener
    {
        public static readonly string Alphabet = "abcdefghijklmnopqrstuvwxyz0123456789";
        public static readonly int Base = Alphabet.Length;

        public static string Encode(int i)

        {

            if (i == 0) return Alphabet[0].ToString();



            var s = string.Empty;



            while (i > 0)

            {

                s += Alphabet[i % Base];

                i = i / Base;

            }



            return string.Join(string.Empty, s.Reverse());

        }



        public static int Decode(string s)

        {

            var i = 0;



            foreach (var c in s)

            {

                i = (i * Base) + Alphabet.IndexOf(c);

            }



            return i;

        }
    }

    
}
