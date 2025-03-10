using System;

class Program
{
    static void Main()
    {
        string name = "";
        string greeting = "";
        Console.WriteLine("Enter your name: ");

        name = Console.ReadLine();

        char[] charArray = { 'H', 'e', 'l', 'l', 'o' };
        for (int i = 0; i < charArray.Length; i++)
        {
            greeting += charArray[i];
        }
        Console.WriteLine(greeting + " " + name);
    }
}


