using System;
using System.Text;

namespace Homework2810
{
    class Program
    {
        static void Main(string[] args)
        {
            



            Console.WriteLine(Reverse("Salam men serxanam"));
        }

        public static string Reverse( string word)
        {
            StringBuilder myString = new StringBuilder(" ");
            for (int i = 0 ; i < word.Length; i++)
			{
                myString.Append(word[word.Length-i]);
			}
            return myString.ToString();
        }
    }
}
