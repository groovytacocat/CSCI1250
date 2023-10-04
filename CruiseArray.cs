/**
*--------------------------------------------------------------------
* File name: CruiseArray.cs
* Project name: CruiseArray
* Solution name: Lab 5
*--------------------------------------------------------------------
* Author’s name and email: Adam Hooven, hoovenar@etsu.edu
* Course-Section: CSCI 1250
* Creation Date: 10/4/2023
* Modified Date: 10/4/2023
* -------------------------------------------------------------------
*/

namespace CruiseArray;


class CruiseArray
{
    static void Main(string[] args)
    {
        int numCruises;
        int minIndex;
        int maxIndex;
        double averagePrice;

        averagePrice = 0;
        minIndex = 0;
        maxIndex = 0;

        Console.WriteLine("Welcome to the Cruise Price Checker!!\n");

        Console.Write("How many cruises are you price checking? ");
        numCruises = int.Parse(Console.ReadLine());

        double[] cruisePrices = new double[numCruises];
        string[] cruiseLocation = new string[numCruises];


        ///<summary>
        /// Prompts user to give a location for a cruise, then prompts user for price of that cruise
        /// Calculates a running total of Cruise prices as they are entered
        /// Stores index of the highest price and the lowest price
        /// Compares the current price value to the value at maxIndex if current is greater maxIndex is set to current index
        /// Same as above however if current price is less than value at minIndex minIndex is set to current index
        ///</summary>
        for(int i = 0; i < numCruises; i++)
        {
            Console.Write($"\nEnter the location of Cruise {i+1}: ");
            cruiseLocation[i] = Console.ReadLine();

            Console.Write($"Enter the price of the Cruise {i+1}: $");
            cruisePrices[i] = double.Parse(Console.ReadLine());

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

        averagePrice /= (double)numCruises;     //Takes total sum of all cruises and divides by number of cruises (cast to double due to being integer) to get average

        Console.WriteLine($"\nMost Expensive Cruise:\n\t{cruiseLocation[maxIndex]}\n\t{cruisePrices[maxIndex]:C}"); //Format to print the price as a currency to include $ a ',' if applicable and rounded to 2 decimal places

        Console.WriteLine($"\nLeast Expensive Cruise:\n\t{cruiseLocation[minIndex]}\n\t{cruisePrices[minIndex]:C}");

        Console.WriteLine($"\nAverage Cruise Price: {averagePrice:C}");

    }
}
