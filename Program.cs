using System.Text;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //check if the two are the same lenght looing via the length and merge 
            //if any one is greater than other , looping via the smallest and get substring from other start from the lenght till the end 

            string word1 = "ab", word2 = "pqrs";
            int minLength = Math.Min(word1.Length, word2.Length);
            var mergedWord = new StringBuilder();

            for (int i = 0; i < minLength; i++)
            {
                mergedWord.Append(word1[i]);
                mergedWord.Append(word2[i]);
            }

            if (word1.Length > minLength)
            {
                mergedWord.Append(word1.Substring(minLength));
            }
            else if (word2.Length > minLength)
            {
                mergedWord.Append(word2.Substring(minLength));
            }

            Console.WriteLine(mergedWord.ToString());
        }

    }
}
