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
        double maxPrice;
        double minPrice;

        averagePrice = 0;
        minIndex = 0;
        maxIndex = 0;
        maxPrice = 0;
        minPrice = 0.0;

        Console.WriteLine("Welcome to the Cruise Price Checker!!\n");

        Console.Write("How many cruises are you price checking? ");
        numCruises = int.Parse(Console.ReadLine());

        double[] cruisePrices = new double[numCruises];
        string[] cruiseLocation = new string[numCruises];


        ///<summary>
        /// Prompts user to give a location for a cruise, then prompts user for price of that cruise
        /// Sets maximum price and minimum price to be the value of the first element in the price array
        /// Compares current value in array to the "Max" value if current index of array is greater/equal price Max is set to that value and maxIndex is assigned the current index
        /// If current price is not greater than Max compares the value to the min if current price is less/equal to min Min gets that value and minIndex gets that index
        /// If not greater than max or less than min program just continues to iterate until array
        /// Also uses averagePrice to store a running total of all costs
        ///</summary>
        for(int i = 0; i < numCruises; i++)
        {
            Console.Write($"\nEnter the location of Cruise {i+1}: ");
            cruiseLocation[i] = Console.ReadLine();

            Console.Write($"Enter the price of the Cruise {i+1}: $");
            cruisePrices[i] = double.Parse(Console.ReadLine());

            averagePrice += cruisePrices[i];

            if(i == 0)
            {
                maxPrice = minPrice = cruisePrices[i];
            }
            
            if (cruisePrices[i] >= maxPrice)
            {
                maxPrice = cruisePrices[i];
                maxIndex = i;
            }
            else if(cruisePrices[i] <= minPrice)
            {
                minPrice = cruisePrices[i];
                minIndex = i;
            }
        }

        averagePrice /= (double)numCruises;     //Takes total sum of all cruises and divides by number of cruises (cast to double due to being integer) to get average

        Console.WriteLine($"\nMost Expensive Cruise:\n\t{cruiseLocation[maxIndex]}\n\t{maxPrice:C2}");

        Console.WriteLine($"\nLeast Expensive Cruise:\n\t{cruiseLocation[minIndex]}\n\t{minPrice:C2}");

        Console.WriteLine($"\nAverage Cruise Price: {averagePrice:C2}");

    }
}
