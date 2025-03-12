using System;

public class CodeAcademy
{
	public static void practice()
	{

        //Console.WriteLine(" .-.\n(O O)\n| o |\n|   |\n'~~~'");


        //string interpolation
        string beginning = "Once upon a time,";
        string middle = "The kid climbed a tree";
        string end = "Everyone lived happily ever after.";

        // Interpolate the string and the variables
        string story = $"{beginning} {middle} {end}";
        Console.WriteLine(story);

    }
}
