using System;

public class BaseBallCode
{
    private int counter = 0;
    private int sum = 0;
    private List<int> BaseBallRecord = new List<int>();
    private int newData;

    public void BaseballScores(string[] ops)
    {
        bool isConvertible = int.TryParse(ops[0], out int score);
        if (!isConvertible)
        {
            Console.WriteLine("First Element is not a number");
            return; 
        }
        foreach (string op in ops)
        {
            if(op == "+")
            {
                newData = BaseBallRecord[counter -1] + BaseBallRecord[counter - 2];
                BaseBallRecord.Add(newData);
            }

            if(op == "D")
            {
                newData = BaseBallRecord[counter - 1] * 2;
                BaseBallRecord.Add(newData);
            }
            if(op == "C")
            {
                BaseBallRecord.Remove(BaseBallRecord[counter - 1]);
            }
            else
            {
                isConvertible = int.TryParse(op, out score);
                if (isConvertible)
                {
                    BaseBallRecord.Add(score);
                }
            }
            counter = BaseBallRecord.Count();
        }
        foreach(int record in  BaseBallRecord) 
        {
            sum += record;
        }
        Console.WriteLine(sum);
    }
}
