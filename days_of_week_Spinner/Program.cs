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

	public static void Main()
	{
        Console.WriteLine("Hello world");
		userInput = Console.ReadLine();

    //int.TryParse is not something you rename every time you use it
        int.TryParse(userInput, out numberprocess);
    //you just put a STRING variable in position 1 and OUT it to an int in position 2

        if (numberprocess % 2 == 0) {
            Console.WriteLine($"{userInput} is Even");
        }
        else
        {
            Console.WriteLine($"{userInput} is Odd");
        }
		
		
	}
}