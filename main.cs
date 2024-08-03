using System;

public class Program
{
    public static void Main()
    {
        string code = GenerateCode();
        Console.WriteLine(code);
    }

    public static string GenerateCode()
    {
        Random random = new Random();
        
        // Generate the first three digits
        string firstPart = random.Next(100, 1000).ToString(); // Ensures 3 digits
        
        // Generate the fourth character (letter)
        char secondPart = (char)random.Next('A', 'Z' + 1);
        
        // Generate the next four digits
        string thirdPart = random.Next(1000, 10000).ToString(); // Ensures 4 digits
        
        // Generate the last character (letter)
        char fourthPart = (char)random.Next('A', 'Z' + 1);
        
        // Combine all parts
        string code = firstPart + secondPart + thirdPart + fourthPart;
        
        return code;
    }
}
