using System;

class Program
{
    static void Main()
    {
        string name = "";
        string greeting = "";
        int age ;

        Console.WriteLine("Enter your name: ");
        name = Console.ReadLine();
        Console.WriteLine("Enter your age: ");
        //age = Convert.ToInt32(Console.ReadLine());
        age = int.Parse( Console.ReadLine());

        char[] charArray = { 'H', 'e', 'l', 'l', 'o' };
        for (int i = 0; i < charArray.Length; i++)
        {
            greeting += charArray[i];
        }
        Console.WriteLine(greeting + " " + name);

        //control statement
        if (age > 18)
        {
            Console.WriteLine("You are a legal Adult");
        }
        else
        {
            Console.WriteLine("You are Underage");
        }
        
    }
}


