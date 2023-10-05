using MyDLL;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace MyDLL
{
    public class CSCI1250
    {
        public interface IValid<T>
        {
            static abstract T Validate(string prompt, string errorMessage, List<T> accepted);
        }

        public class CharValid : IValid<char>
        {
            public static char Validate(string prompt, string errorMessage, List<char> accepted)
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
                    input = Validate(prompt, errorMessage, accepted);
                }

                if (!(accepted.Contains(input)))
                {
                    Console.WriteLine(errorMessage);
                    input = Validate(prompt, errorMessage, accepted);
                } 

                return input;
            }
        }

        public class IntValid : IValid<int>
        {
            public static int Validate(string prompt, string errorMessage, List<int> accepted)
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
                    input = Validate(prompt, errorMessage, accepted);
                }

                if(input < accepted[0] || input > accepted[^1])
                {
                    Console.WriteLine(errorMessage);

                    input = Validate(prompt, errorMessage, accepted);
                }

                return input;
            }
        }

        public class DoubleValid : IValid<double>
        {
            public static double Validate(string prompt, string errorMessage, List<double> accepted)
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
                    input = Validate(prompt, errorMessage, accepted);
                }

                if (input < accepted[0] || input > accepted[^1])
                {
                    Console.WriteLine(errorMessage);

                    input = Validate(prompt, errorMessage, accepted);
                }

                return input;
            }
        }
    }
}
