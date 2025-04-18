﻿using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Linq;

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

    public static string changeToUpperCase(string word) {
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

    public static void arrayManupilation()
    {

        string[] summerStrut;
        summerStrut = new string[] {
          "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel", "Despacito", "Los Angeles"
        };

        int[] ratings = { 1, 2, 3, 4, 5, 4, 4, 3 };

        for (int i = 0; i < summerStrut.Length; i++)
        {
            //Console.WriteLine(summerStrut[i]);
        }
        Console.WriteLine($"{summerStrut[1]} {ratings[1]}ratings");
    }

    public static void arrayMethods()
    {
        string[] summerStrut;

        summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };

        int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };
        int threeRating = Array.IndexOf(ratings, 3);
        Console.WriteLine($"Song number {threeRating + 1} is rated three stars.");
        Array.Reverse(summerStrut);
        Console.WriteLine(summerStrut[0]);
        Console.WriteLine(summerStrut[7]);
        Array.Sort(summerStrut);

    }

    public static void loopsTry()
    {
        string[] todo = { "respond to email", "make wireframe", "program feature", "fix bugs" };

        foreach (string task in todo)
        {
            Console.WriteLine($"[] {task}");
        }
    }

    public static void tryLists()
    {
        List<int> numbers = new List<int>();
        numbers.Add(10);
        numbers.AddRange(new int[] { 20, 50, 40 });
        //numbers.Sort();
        numbers.Reverse();

        foreach (int num in numbers) {
            Console.WriteLine(num);
        }
    }

    public static void printSecondName(string name)
    {
        int indexOfSpace = name.IndexOf(" ");
        string secondName = name.Substring(indexOfSpace + 1);
        Console.WriteLine(secondName);
    }

    public string courseName;
    public string courseDescription;
    public  int courseCredit;

    public override string ToString()
    {
        return $" Learning {courseName} {courseDescription} with {courseCredit} credits";
    }

    public CodeAcademy(string courseName, string courseDescription, int courseCredit)
    {
        this.courseName = courseName;
        this.courseDescription = courseDescription;
        this.courseCredit = courseCredit;
    }
    
    

    

    public static void replaceA()
    {
        string[] heroes = { "Zoe", "Liam", "Taryn", "Dorian", "Everett", "Marlena" };
        // var underscored = from h in heroes
        //     select h.Replace("a","_");
        var underscored = heroes.Select(hero => hero.ToUpper());
        
        foreach (string hero in underscored)
        {
            Console.WriteLine(hero);
        }
    }

    public static void containsLetterI()
    {
        string[] heroes = { "Zoe", "Liam", "Taryn", "Dorian", "Everett", "Marlena" };
        // var heroesWithI = from h in heroes
        //     where h.Contains("i")
        //     select h;

        var heroesWithI = heroes.Where(hero => hero.Contains("i"));

        foreach (string hero in heroesWithI)
        {
            Console.WriteLine(hero);
        }
    }

}
