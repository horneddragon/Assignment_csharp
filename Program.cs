﻿using System;
//1. Write a C# Sharp program to print the output of multiplication of three numbers which
// will be entered by the user
class Exercise1
{
    public static void Main()
    {
        Console.WriteLine("Enter value of a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter value of b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter value of c: ");
        int c = Convert.ToInt32(Console.ReadLine());

        int total = a * b * c;
        Console.WriteLine($"Total of {a} * {b} * {c} is {total}");
    }
}

//2.Write a C# program that accepts and 2 numbers and prints the small no


class Exercise2
{
    public static void Main()
    {
        Console.WriteLine("Enter first no: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second no: ");
        int b = Convert.ToInt32(Console.ReadLine());
         if (a > b)
        {
            Console.WriteLine($"{b} is the smallest!");
        }
         else
        {
            Console.WriteLine($"{a} is the smallest!");
        }
    }
}

//3. Accept a string from the user and return the count of vowels in the string


class Exercise3
{
    public static void Main()
    {
        string names = Console.ReadLine();

        for(int i = 0; i < names.Length; i++ )
        {
            if (names[i] == ( 'a' | 'e' | 'i' | 'o' | 'u' ))
            {
                var counter = 1;
                counter = counter + 1;
                Console.WriteLine($"count is {counter}");
            }
        }
    }
}

//4. Accept a string from the user and return count of words

class Exercise4
{
    public static void Main()
    {
        Console.WriteLine("Enter name:");
        var name = Console.ReadLine();
        Console.WriteLine(name.Length);
    }
}

//5.Write a C# program to create a new string from a given string where the
//first and last characters will change their positions
class Exercise5
{
    public static void Main()
    {
        var name = Console.ReadLine();
        var split_name = name.Split();
        

        for (int i = 0; i <= split_name.Length; i++)
        {
            for(int j = 0; j <= i; j++) { 
            }
        }
    }
}

//6. Write a program that prints on the console the current date and time.

class Exercise6
{
    public static void Main()
    {

        DateTime now = DateTime.Now;
        Console.WriteLine(now);
    }
}

    //7.Write a program that reads your age from the console and prints your age after 10 years.
class Exercise7
    {
        public static void Main()
        {
            Console.WriteLine("Enter year");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(year + 10);
        }
    }

public class exercise31
{
    public static void Main()
    {
        string myStr;
        int i, len, vowel_count, cons_count;
        Console.WriteLine("Input string: ");
        myStr = (Console.ReadLine());
        vowel_count = 0;
        cons_count = 0;
        // find length
        len = myStr.Length;
        for (i = 0; i < len; i++)
        {
            if (myStr[i] == 'a' || myStr[i] == 'e' || myStr[i] == 'i' || myStr[i] == 'o' || myStr[i] == 'u' || myStr[i] == 'A' || myStr[i] == 'E' || myStr[i] == 'I' || myStr[i] == 'O' || myStr[i] == 'U')
            {
                vowel_count++;
            }
            else
            {
                cons_count++;
            }
        }
        Console.Write("\nVowels in the string: {0}\n", vowel_count);
    }
}