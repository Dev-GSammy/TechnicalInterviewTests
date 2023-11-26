public class StringSplit
{
    private int counter = 0;
    

    public int Split(string s)
    {
       var letter = s[s.Length - 1];
        for (int j=s.Length - 1; j>=0; j--)
        {
            if (letter == '-')
            {
                counter = 0;
            }
            else
            {
                if (s[j] == '-')
                {
                    Console.WriteLine(counter);
                    return counter;
                }
                else
                {
                    counter++;
                }
            }
            letter = '!';
        }
        Console.WriteLine(counter);
        return counter; 
    }
}

