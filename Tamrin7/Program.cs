
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.Write("Yek reshte vared konid: ");
        string input = Console.ReadLine();

        string pattern = @"0\d{9}";
        Regex regex = new Regex(pattern);

        foreach (Match match in regex.Matches(input))
        {
            if (HasAtLeastTwoDifferentDigits(match.Value))
            {
                Console.WriteLine($"Shomareh telephone motabar: {match.Value}");
            }
        }
    }

    static bool HasAtLeastTwoDifferentDigits(string number)
    {
        char firstDigit = number[0];
        for (int i = 1; i < number.Length; i++)
        {
            if (number[i] != firstDigit)
            {
                return true;
            }
        }
        return false;
    }
}
