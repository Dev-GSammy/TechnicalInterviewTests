

namespace TechnicalInterviewTests.String_And_Array
{
    public class Isomorphs
    {
        //I did this before looking at hers. She also did something like this but more complicated with if-else lines of code.
        //so basically, she created two arrays to store checked element of each strings, then compare if they have been seen before. 
        public void IsomorphicStrings(string a, string b)
        {
            if(a.Length != b.Length) 
            {
                throw new Exception("They are not isomorphic");
            }
            else
            {
                for(int i = 0; i < a.Length; i++)
                {
                    if (a[i] == b[i])
                    {
                        if (a.Contains(a[i]) && a.IndexOf(a[i]) != i)
                        {
                            Console.WriteLine("They are isomorphic");
                            return;
                        }
                        else
                        {
                            Console.WriteLine("They are not isomorphic");
                            return;
                        }
                    }
                    else
                    {
                        if (a.Contains(a[i]) && a.IndexOf(a[i]) != i && a[i] != b[i])
                        {
                            Console.WriteLine("They are isomorphic");
                            return;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                Console.WriteLine("They are isomorphic");
            }
        }
    }
}
