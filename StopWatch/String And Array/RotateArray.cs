

namespace TechnicalInterviewTests.String_And_Array
{
    public class RotateArray
    {
        ////I got this right in one solve. Took about 20min though. The tutor's method seems thrice longer while our time comp remains the same.
        public void Rotate_Array(int[] numbers, int k)
        {
            int length = numbers.Length;
            int[] storeArray = new int[k];
            for(int i = 0; i<k; i++)
            {
                storeArray[i] = numbers[i];
            }


            int diff = length - k;
            for(int j = 0; j< diff; j++)
            {
                numbers[j] = numbers[j + k];
            }


            foreach(int member in storeArray)
            {
                numbers[diff] = member;
                diff++;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + ", ");
            }
        }
    }
}
