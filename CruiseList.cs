

using System;
/**
*--------------------------------------------------------------------
* File name: CruiseList.cs
* Project name: CruiseList
* Solution name: Lab 5
*--------------------------------------------------------------------
* Author’s name and email: Adam Hooven, hoovenar@etsu.edu
* Course-Section: CSCI 1250
* Creation Date: 10/4/2023
* Modified Date: 10/4/2023
* -------------------------------------------------------------------
*/

namespace CruiseList;


/*
 
 Create the same program above except with a List with a few differences:
 Don’t ask the user how many cruises at the beginning of the program. Instead, ask the user if there is another
cruise to add. Continue adding cruise locations and prices until the user doesn’t have more to add.
 
 
 */
class CruiseList
{
    static void Main(string[] args)
    {
        List<string> cruiseLocation = new List<string>();
        List<double> cruisePrices = new List<double>();

        double maxPrice;
        double minPrice;
        double averagePrice;
        int maxIndex;
        int minIndex;
        char userChoice;

        averagePrice = 0.0;

        maxIndex = 0;
        minIndex = 0;

        Console.WriteLine("Welcome to the Cruise Price Checker!! (Now with a Lists)\n");

        ///<summary>
        /// Prompts user to enter a cruise location and a price
        /// After getting values from user asks if user wishes to add another
        /// If user inputs 'n' or "N" ends loading the cruise price/location
        ///</summary>
        do
        {
            Console.Write("Enter a Cruise Location: ");
            cruiseLocation.Add(Console.ReadLine());

            Console.Write("Enter the price of the cruise: $");
            cruisePrices.Add(double.Parse(Console.ReadLine()));

            Console.Write("\nWould you like to add another cruise? ");
            userChoice = char.ToUpper(char.Parse(Console.ReadLine()));
            Console.WriteLine();

        } while (userChoice != 'N');

        //Set Max and Min to first element array before comparing values
        maxPrice = cruisePrices[0];
        minPrice = cruisePrices[0];


        ///<summary>
        /// Iterates through Cruise Prices and stores running total in Average
        /// Compares current price value to the max, if current price is greater then maxPrice is set to the current price
        /// If current value isn't greater then checks if it is less than minPrice if so minPrice is set to current value
        ///</summary>
        for(int i = 0; i < cruisePrices.Count; i++)
        {
            averagePrice += cruisePrices[i];

            if (cruisePrices[i] >= maxPrice)
            {
                maxPrice = cruisePrices[i];
                maxIndex = i;
            }
            else if (cruisePrices[i] <= minPrice)
            {
                minPrice = cruisePrices[i];
                minIndex = i;
            }
        }

        averagePrice /= (double)cruisePrices.Count;

        Console.WriteLine($"\nMost Expensive Cruise:\n\t{cruiseLocation[maxIndex]}\n\t{maxPrice:C2}");

        Console.WriteLine($"\nLeast Expensive Cruise:\n\t{cruiseLocation[minIndex]}\n\t{minPrice:C2}");

        Console.WriteLine($"\nAverage Cruise Price: {averagePrice:C2}");
    }
}

