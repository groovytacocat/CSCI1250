/**
*--------------------------------------------------------------------
* File name: Seasons.cs
* Project name: Lab3Seasons
* Solution name: Lab3
*--------------------------------------------------------------------
* Author’s name and email: Adam Hooven, hoovenar@etsu.edu
* Course-Section: CSCI 1250
* Creation Date: 09/20/2023
* Modified Date: 09/20/2023
* -------------------------------------------------------------------
*/
namespace Lab3Seasons;


/// <summary>
/// Class that has 5 (Autumn/Fall) Seasons and their translation to Spanish
/// Prompts user for a season and then prints its translation out to the user
/// If a user provided something that is not a season they are notified
/// Thanks the user for using program
/// </summary>

class Seasons
{
    static void Main(string[] args)
    {
        //Variable declarations and pre-defined spanish translations
        string inputSeason;
        string translateSpring = "la primavera";
        string translateSummer = "el Verano";
        string translateAutumnFall = "el otono";
        string translateWinter = "el invierno";

        Console.WriteLine("Enter the name of a season and I'll translate it to Spanish");
        inputSeason = Console.ReadLine();

        ///<summary>
        /// Converts input string to all uppercase to avoid any issues with all lower or mixed case of a season
        /// </summary>
        switch(inputSeason.ToUpper())
        {
            case "SPRING":
                Console.WriteLine($"{inputSeason.ToUpper()} in Spanish is {translateSpring}");
                break;
            case "SUMMER":
                Console.WriteLine($"{inputSeason.ToUpper()} in Spanish is {translateSummer}");
                break;
            case "AUTUMN":
                Console.WriteLine($"{inputSeason.ToUpper()} in Spanish is {translateAutumnFall}");
                break;
            case "FALL":
                Console.WriteLine($"{inputSeason.ToUpper()} in Spanish is {translateAutumnFall}");
                break;
            case "WINTER":
                Console.WriteLine($"{inputSeason.ToUpper()} in Spanish is {translateWinter}");
                break;
            default:
                Console.WriteLine($"{inputSeason.ToUpper()} is an invalid season.");
                break;
        }

        Console.WriteLine("Thank you for using my program!");
    }
}

