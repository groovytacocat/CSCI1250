using MyDLL;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace MyDLL
{
    public class CSCI1250
    {
        public static char CharValidate(string prompt, string errorMessage, List<char> accepted)
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
                input = CharValidate(prompt, errorMessage, accepted);
            }

            if (!(accepted.Contains(input)))
            {
                Console.WriteLine(errorMessage);
                input = CharValidate(prompt, errorMessage, accepted);
            }

            return input;
        }

        public static int IntValidate(string prompt, string errorMessage, int min, int max)
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
                input = IntValidate(prompt, errorMessage, min, max);
            }

            if (input < min || input > max)
            {
                Console.WriteLine(errorMessage);

                input = IntValidate(prompt, errorMessage, min, max);
            }

            return input;
        }

        public static double DoubleValidate(string prompt, string errorMessage, int min, int max)
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
                input = DoubleValidate(prompt, errorMessage, min, max);
            }

            if (input < min || input > max)
            {
                Console.WriteLine(errorMessage);

                input = DoubleValidate(prompt, errorMessage, min, max);
            }

            return input;
        }
    }
}