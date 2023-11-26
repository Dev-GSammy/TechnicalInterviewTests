using System;

public class PerfectIntegers
{
    public void PerfectInteger(int x, int y)
    {
        int a = 0;
        int[] perfectIntegers = new int[y-x+1];
        while(x <= y)
        {
            int b = x;
            string digit = x.ToString();
            for(int c = 0; c<=digit.Length-1; c++)
            {
                int j = digit[c] - '0';
                if(x%j == 0)
                {
                    continue;
                }
                else
                {
                    b = 0;
                    break;
                }
            }
            perfectIntegers[a] = b;
            x++;
            a++;
        }
        foreach (int i in perfectIntegers)
        {
            Console.Write(i + ", ");
        }
    }
}