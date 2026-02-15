using System;
using System.Globalization;

public class Program
{
   //write new program logic in the top
   //at the bottom we are repurposing logic we just made in the previous program
		
/* 
Objective: Combine arrays, Random, and %.

Requirements:

Create a string[] with 7 days: Sun–Sat.

Generate a random number (e.g., 0–99).

Use % 7 to choose the index.

Example Output:

Random number: 15 Day: Monday
*/
static string[] sevenDays = new string[] {"Sunday", "Monday", "Tuesday", "Wednesday",
 "Thursday", "Friday", "Saturday"};

 //static random???
 // static int spinRand = rand.Next(0, 101);
 static int DayResult;

	public static void Main()
	{
        Console.WriteLine("\nWelcome to Days of the Week, a spinner made just for you");
        Console.WriteLine("Please press ENTER for a new Spin!");
		Console.ReadKey();
         Console.WriteLine("\nLook at that Spinner go! That was a good flick");

    //I learned that new Random can be seeded with time or your own choice of any
    //number seed. I also learned that rand.next can take arguments for lower and 
    // upper bound requirements numberline style, negatives included:
    //                               int spinRand = rand.Next(-77, 189);
        Random rand = new Random(11);
        int spinRand = rand.Next(0, 101);
        //7 day logic now available
        DayResult = spinRand % 7;
        if (DayResult == 1)
        { 
        //newline note, i got annoyed at the terminal listing my name 
        // on the very next line under my result because the program closes, so I fixed it
            Console.WriteLine($"The spinner says: {sevenDays[0]} \n");
        } 
        if (DayResult == 2)
        {
            Console.WriteLine($"The spinner says: {sevenDays[1]} \n");
        }
        if (DayResult == 3)
        {
            Console.WriteLine($"The spinner says: {sevenDays[2]} \n");
        }
        if (DayResult == 4)
        {
            Console.WriteLine($"The spinner says: {sevenDays[3]} \n");
        }
        if (DayResult == 5)
        {
            Console.WriteLine($"The spinner says: {sevenDays[4]} \n");
        }
        if (DayResult == 6)
        {
            Console.WriteLine($"The spinner says: {sevenDays[5]} \n");
        }
        if (DayResult == 7)
        {
            Console.WriteLine($"The spinner says: {sevenDays[6]} \n");
        }
            
		
		
	}
}