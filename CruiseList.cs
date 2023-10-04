

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
class CruiseList
{
    static void Main(string[] args)
    {
        List<string> cruiseLocation = new List<string>();
        List<double> cruisePrices = new List<double>();

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

        ///<summary>
        /// Iterates through Cruise Prices and stores running total in Average
        /// Compares current price value to that of the value at the index of maxIndex if it is greater then maxIndex gets the index of current price
        /// Same as above but for the minimum case
        ///</summary>
        for(int i = 0; i < cruisePrices.Count; i++)
        {
            averagePrice += cruisePrices[i];

            if (cruisePrices[i] >= cruisePrices[maxIndex])
            {
                maxIndex = i;
            }
            else if (cruisePrices[i] <= cruisePrices[minIndex])
            {
                minIndex = i;
            }
        }

        averagePrice /= (double)cruisePrices.Count; //Takes running total calculated from above and gets average by dividing by the number of cruises (cast to a double to avoid truncation of the decimal)

        Console.WriteLine($"\nMost Expensive Cruise:\n\t{cruiseLocation[maxIndex]}\n\t{cruisePrices[maxIndex]:C}");

        Console.WriteLine($"\nLeast Expensive Cruise:\n\t{cruiseLocation[minIndex]}\n\t{cruisePrices[minIndex]:C}");

        Console.WriteLine($"\nAverage Cruise Price: {averagePrice:C}");
    }
}

