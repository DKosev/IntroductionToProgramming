using System;

class AgeAfterTenYears
{
    static void Main()
    {
        int bornYear;
        int currentAge;
        int currentYear = DateTime.Now.Year;
        
        Console.WriteLine("Enter your birth year: ");
        bornYear = int.Parse(Console.ReadLine());
        currentAge = currentYear - bornYear;

        if (1880 <= bornYear && bornYear <= currentYear)
        {
            Console.WriteLine("You are {0} years old and after ten years you will be {1} years old!", currentAge, currentAge + 10);
        }
        else
        {
            Console.WriteLine("You have entered an invalid year!");
        }
    }
}
