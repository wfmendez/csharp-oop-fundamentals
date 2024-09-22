using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string valueFromUser = Console.ReadLine();
        int grade = int.Parse(valueFromUser);
        string gradeLetter = "N/A";

        if (grade >= 90)
        {
            gradeLetter = "A";
        }
        else if (grade >= 80)
        {
            gradeLetter = "B";
        }
        else if (grade >= 70)
        {
            gradeLetter = "C";
        }
        else if (grade >= 60)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }

        int lastDigit = grade % 10;
        string sign = "";

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }

        if (gradeLetter == "A" && sign == "+")
        {
            sign = "";
        }
        else if (gradeLetter == "F")
        {
            sign = "";
        }

        Console.WriteLine($"Your grade letter is {gradeLetter}{sign}");
        if (grade >= 70)
        {
            Console.WriteLine("Congratulatios you pass the class!!!");
        }
        else
        {
            Console.WriteLine("Sorry you don't pass the class, we encourage to try it again in the next semester");
        }
    }
}