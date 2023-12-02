
using System.Text;

namespace TechnicalInterviewTests.String_And_Array
{
    public class InfoWareTest
    {
        public string changeCharacter(string String)
        {
            string resultString = "";
            var resultStringBuilder = new StringBuilder("");  //truing to experiment the use of stringbuilder in comparison to string.
            for (int stringCharacter = 0; stringCharacter < String.Length; stringCharacter++)
            {
                if (String[stringCharacter] == '>')
                {
                    resultString += "&GT";
                    resultStringBuilder.Append("&GT");
                }
                else if (String[stringCharacter] == '<')
                {
                    resultString += "&LT";
                    resultStringBuilder.Append("&LT");
                }
                else
                {
                    resultString += String[stringCharacter];
                    resultStringBuilder.Append(String[stringCharacter]);
                }
            }
            Console.WriteLine(resultStringBuilder);
            Console.WriteLine("\n");
            return resultString;
        }
    }
}
