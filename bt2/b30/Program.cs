using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1, 21, 23, 43, 456 };
        List<int> increasingNum = FindIncreasingNumbers(numbers);
        Console.WriteLine($"Cac so tang la: {string.Join(", ", increasingNum)}");
    }

    static List<int> FindIncreasingNumbers(List<int> numbers)
    {
        List<int> result = new List<int>();
        foreach (int num in numbers)
        {
            string numStr = num.ToString();
            bool isIncreasing = true;
            for (int i = 0; i < numStr.Length - 1; i++)
            {
                if (numStr[i] > numStr[i + 1])
                {
                    isIncreasing = false;
                    break;
                }
            }
            if (isIncreasing)
            {
                result.Add(num);
            }
        }
        return result;
    }   
}
