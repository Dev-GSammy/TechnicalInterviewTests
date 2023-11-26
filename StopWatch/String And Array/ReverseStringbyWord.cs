

using System.Collections;

namespace TechnicalInterviewTests.String_And_Array
{
    public class ReverseStringbyWord
    {
        public void ReverseString(string sentence)// Take "Why does this take so long" as sentence
        {
            //using inbuilt functions
            string[] strings = sentence.Split(' ').Reverse().ToArray();
            foreach (string s in strings)
            {
                //Console.WriteLine(s);
            }

            //the following code just reverses sentence by characters not words
            char[] reversedstring = new char[sentence.Length];
            int count = sentence.Length - 1; 
            foreach(char c in sentence)
            {
                reversedstring[count] = c;
                count--;
            }
          

            foreach(char c in reversedstring)
            {
                //Console.Write(c);
            }

            //using list
            char[] reversestring = new char[10];
            int news = 9;
            string concat = "";
            for(int c = sentence.Length-1; c >= 0; c--)
            {
                reversestring[news] = sentence[c];
                if (sentence[c] == ' ')
                {
                    concat += reversestring.ToString();
                    reversestring = new char[10];
                    news = 9;
                }
                news--;
            }
            Console.WriteLine(concat);
        }
    }
}
