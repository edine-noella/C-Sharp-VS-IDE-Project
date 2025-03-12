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

}
