using MyDLL;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace MyDLL
{
    public class CSCI1250
    {
        public static int ValidateInt(string prompt, string errorMessage, int MIN, int MAX)
        {
            int input;

            Console.Write(prompt);

            try
            {
                input = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                input = ValidateInt(prompt, errorMessage, MIN, MAX);
            }
            if(input < MIN || input > MAX)
            {
                Console.WriteLine(errorMessage);
                input = ValidateInt(prompt, errorMessage, MIN, MAX);
            }

            return input;
        }

        public static double ValidateDouble(string prompt, string errorMessage, double MIN, double MAX)
        {
            double input;

            Console.Write(prompt);

            try
            {
                input = double.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                input = ValidateDouble(prompt, errorMessage, MIN, MAX);
            }
            if(input < MIN || input > MAX)
            {
                Console.WriteLine(errorMessage);
                input = ValidateDouble(prompt, errorMessage, MIN, MAX);
            }

            return input;
        }

        public static char ValidateChar(string prompt, string errorMessage, List<char> accepted)
        {
            char input;

            Console.Write(prompt);

            try
            {
                input = char.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                input = ValidateChar(prompt, errorMessage, accepted);
            }
            if(!(accepted.Contains(input))
            {
                Console.WriteLine(errorMessage);
                input = ValidateChar(prompt, errorMessage, accepted);
            }

            return input;
        }
        
        }
    }
}
