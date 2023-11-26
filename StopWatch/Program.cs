using System;
using TechnicalInterviewTests;
using TechnicalInterviewTests.String_And_Array;

namespace NewClass
{
    public class Program()
    {
        
        static void Main(string[] args)
        {
            var baseballcode = new BaseBallCode();
            //baseballcode.BaseballScores(new string[]{ "5", "-2", "4", "C", "D", "9", "+", "+"});
            var stringIssue = new StringSplit();
            //stringIssue.Split("-Emeka-is-no-Stallion-");
            var perfectIntegers = new PerfectIntegers();
            //perfectIntegers.PerfectInteger(142, 145);
            var fizzbuzz = new FizzBuzz();
            //fizzbuzz.Fizzbuzz(50);
            var reversestringbywords = new ReverseStringbyWord();
            //reversestringbywords.ReverseString("Why does this look so long");
            var rotateArray = new RotateArray();
            //rotateArray.Rotate_Array([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13,14, 15, 16, 17, 18, 19, 20], 5);
            var isomorphic = new Isomorphs();
            //isomorphic.IsomorphicStrings("welcome", "naughty");
            var kthsmallest = new KthSmallestElement();
            kthsmallest.KthSmallest([3, 2, 1, 5, 6, 4], 3);
            
        }
       
    }
    
}


