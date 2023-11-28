

namespace TechnicalInterviewTests.String_And_Array
{
    public class KthSmallestElement
    {
        //Solved this on my own. The only problem is that the time complexity is n*2. 
        public void KthSmallest(int[] array, int k)
        {
            int holder;
            if (k > 0 && k<array.Length)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length-1; j++)
                    {
                        if (array[j] > array[j + 1])
                        {
                            holder = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = holder;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                foreach(int c in array)
                {
                    Console.Write(c+", ");
                }
                Console.WriteLine();
                Console.WriteLine("The {0}th smallest is {1}", k, array[k-1]);
            }
            else
            {
                Console.WriteLine("K is either less than 1 or k is bigger than the size of array.");
            }  
        }
    }
}
