

namespace TechnicalInterviewTests.String_And_Array
{
    public class KthSmallestElement
    {
        //Solved this on my own. The only problem is that the time complexity is n*2. 
        public void KthSmallest(int[] array, int k)
        {
            int holder;
            if (k > 0)
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
                Console.WriteLine(array[k - 1]);
            }
            else
            {
                Console.WriteLine("K is an unrealistic number");
            }  
            
        }
    }
}
