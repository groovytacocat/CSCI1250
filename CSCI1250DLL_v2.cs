namespace MyDLL
{

    public class CSCI1250
    {
        public static T Parse<T>(string s, IFormatProvider provider) where T : IParsable<T>
        {
            return T.Parse(s, provider);
        }

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
                input = Validate<T>(prompt, errorMessage, accepted);
            }

            if (!(accepted.Contains(input)))
            {
                Console.WriteLine(errorMessage);
                input = Validate<T>(prompt, errorMessage, accepted);
            }

            return input;
        }

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
    }
}
