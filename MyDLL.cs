namespace MyDLL
{

    public class CSCI1250
    {
        //Generic Parse method implemented by IParsable<T>
        public static T Parse<T>(string s, IFormatProvider provider) where T : IParsable<T>
        {
            return T.Parse(s, provider);
        }

        ///<summary>
        /// Generic Validate Method that takes a prompt, an error message, and a generic List of values to compare the input read from console
        /// If the user input throws an exception when parsing errormessage is displayed and the validate method gets a recursive call
        /// Concept in mind for this method is for when desired input must match pre-determined values
        ///     E.g. Y/N questions, Multiple Choice questions, Number values where they must match a set of values known prior to running program
        ///</summary>
        public static T Validate<T>(string prompt, string errorMessage, List<T> accepted) where T : IParsable<T>
        {
            T input;

            Console.WriteLine(prompt);

            try
            {
                input = Parse<T>(Console.ReadLine(), null);
            }
            catch
            {
                Console.WriteLine(errorMessage);
                input = Validate(prompt, errorMessage, accepted);
            }

            if (!(accepted.Contains(input)))
            {
                Console.WriteLine(errorMessage);
                input = Validate(prompt, errorMessage, accepted);
            }

            return input;
        }

        ///<summary>
        /// Generic Validate Method that takes a prompt, an error message
        /// If the user input throws an exception when parsing errormessage is displayed and the validate method gets a recursive call
        /// Similar to the above however this works for when you have numeric inputs that need to be within a range
        ///     E.g. A < input < B / input > 0 / or where a list of accepted values may be so large that it would not be sensible to declare/initialize
        ///</summary>
        public static T Validate<T>(string prompt, string errorMessage) where T : IParsable<T>
        {
            Console.WriteLine(prompt);

            try
            {
                return Parse<T>(Console.ReadLine(), null);
            }
            catch
            {
                Console.WriteLine(errorMessage);
                return Validate<T>(prompt, errorMessage);
            }
        }


        ///<summary>
        /// Method that returns a boolean to be used when prompting a user if they would like to repeat a program/method/action
        /// Only accepts y, Y, n, or N as values
        /// Returns true for user input of y/Y 
        ///</summary>
        public static bool Repeat(string prompt, string errorMessage)
        {
            char repeat;

            do
            {
                repeat = char.ToUpper(Validate<char>(prompt, errorMessage));

                if (!(repeat == 'Y' || repeat == 'N'))
                {
                    Console.WriteLine(errorMessage);
                }
            } while (!(repeat == 'Y' || repeat == 'N'));

            return repeat == 'Y' ? true : false;

        }

        /// <summary>
        /// Generic that swaps the valuables of 2 variables
        /// </summary>
        /// <typeparam name="T">Type of values being swapped</typeparam>
        /// <param name="x">Value 1 to be swapped</param>
        /// <param name="y">Value 2 to be swapped</param>
        public static void Swap<T> (ref T x, ref T y)
        {
            T swap = y;

            y = x;

            x = swap;
        }
    }
}
