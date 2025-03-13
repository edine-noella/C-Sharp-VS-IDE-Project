using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

public class CodeAcademy
{
    public static void practice()
    {
    }

    public static void passwordValidate()
    {

        string password = "a92301j2add";
        int passwordLength = password.Length;
        int passwordCheck = 0;


        ;
        for (int i = 0; i < passwordLength; i++)
        {
            if (!Char.IsLetter(password[i]))
            {
                passwordCheck++;
            }
        }

        Console.WriteLine($"The user password is {password}. Its length is {passwordLength} and it contains {passwordCheck} special characters.");
    }

    public static string changeToUpperCase (string word){
        return word.ToUpper();
    }

    public static void checkAcidity(double ph)
    {

        switch (ph)
        {
            case <= 3:
                Console.WriteLine("Very Acidic");
                break;
            case < 7:
                Console.WriteLine("Acidic");
                break;
            case >= 11:
                Console.WriteLine("Very Basic");
                break;
            case > 7:
                Console.WriteLine("Basic");
                break;
            default:
                Console.WriteLine("Neutral");
                break;
        }
    }

    public static string ternaryOperator(int age)
    {
        return (age > 18) ? "You are under age" : "You age a legal adult";
    }

}
