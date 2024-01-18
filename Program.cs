using Mission2;
using System;
using System.Runtime.InteropServices;
// Abby Harris
// Section 001
// This program simulates the rolling of two dice (1-6 numeric value) and prints out a histogram to represent the results
internal class Program
{
    private static void Main(string[] args)
    {
        RollDice roller = new RollDice();
        // get user input 
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.WriteLine("How many dice rolls would you like to simulate?");

        // change input from string to int 
        int numRolls = int.Parse(Console.ReadLine());

        // create an int array and connect the number of rolls to the class and method that simulates the rolling of the dice 
        int[] results = roller.DiceRoll(numRolls);

        PrintHistogram(results, numRolls);
    }
    // method to print the results and the histogram 
    static void PrintHistogram(int[] results, int numRolls) 
    {
        int totalRolls = results.Sum();
        Console.WriteLine($"\nDICE ROLLING SIMULATION RESULTS\nEach '*' represents 1% of the total number of rolls.\nTotal number of rolls = {numRolls}");
        for (int i = 2; i <= 12; i++)
        {
            int percentage = (results[i]*100 / numRolls);
            Console.Write($"{i}: {new string('*', percentage)}\n");
        }
        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}