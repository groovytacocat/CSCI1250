using System.ComponentModel.Design;
using System.ComponentModel.Design.Serialization;
using System.Runtime.CompilerServices;

namespace CSCI
{
    internal class CSCI1250
    {
        const double PACKAGE_A_PRICE = 9.95;
        const double PACKAGE_B_PRICE = 13.95;
        const double PACKAGE_C_PRICE = 19.95;

        const double INCLUDED_A_BOOKS = 10;
        const double INCLUDED_B_BOOKS = 20;

        const double EXTRA_A_BOOKS = 2.0;
        const double EXTRA_B_BOOKS = 1.0;
        class Lab2
        {
            public class Wages
            {
                private string name;
                private double regPay, otPay, regHours, otHours, totalWages;

                public string Name
                {
                    get
                    {
                        return this.name;
                    }
                }

                public double RegPay
                {
                    get
                    {
                        return this.regPay;
                    }
                    set
                    {
                        this.regPay = value;
                    }
                }

                public double OTPay
                {
                    get
                    {
                        return this.otPay;
                    }
                    set
                    {
                        this.otPay = value;
                    }
                }

                public double RegHours
                {
                    get
                    {
                        return this.regHours;
                    }
                    set
                    {
                        this.regHours = value;
                    }
                }

                public double OTHours
                {
                    get
                    {
                        return this.otHours;
                    }
                    set
                    {
                        this.otHours = value;
                    }
                }

                public double TotalWage
                {
                    get
                    {
                        return this.totalWages;
                    }
                    set
                    {
                        this.totalWages = value;
                    }
                }

                public void GetPays()
                {
                    Console.Write("Enter your Regular pay: ");
                    regPay = double.Parse(Console.ReadLine());

                    Console.Write("Enter your Overtime pay: ");
                    otPay = double.Parse(Console.ReadLine());
                }

                public void GetHours()
                {
                    Console.Write("Enter number of Regular Hours worked: ");
                    regHours = double.Parse(Console.ReadLine());

                    Console.Write("Enter the number of Overtime Hours worked: ");
                    otHours = double.Parse(Console.ReadLine());
                }

                public double TotalWages
                {
                    get
                    {
                        return this.totalWages;
                    }
                    set
                    {
                        CalculateWage(regPay, otPay, regHours, otHours);
                    }
                }

                public double CalculateWage(double rPay, double oPay, double rHours, double oHours)
                {
                    return (rPay * rHours) + (oPay * oHours);
                }

                public Wages (string inName, double inRegPay, double inOTPay, double inRegHours, double inOTHours)
                {
                    name = inName;
                    regPay = inRegPay;
                    otPay = inOTPay;
                    regHours = inRegHours;
                    otHours = inOTHours;
                }
                public Wages(string inName) : this(inName, 0, 0, 0, 0) { }
            } //END of Wages Class

            public class Madlibs
            {
                private string userName, city, country, profession, animal, petName;
                private int userAge;

                public string Name
                {
                    get;
                    set;
                }
                public string City
                {
                    get;
                    set;
                }

                public string Country
                {
                    get;
                    set;
                }

                public string Job
                {
                    get;
                    set;
                }
                
                public string Animal
                {
                    get;
                    set;
                }

                public string PetName
                {
                    get;
                    set;
                }

                public int Age
                {
                    get;
                    set;
                }
                public void GetLibs()
                {
                    Console.Write("Enter your name: ");
                    this.Name = Console.ReadLine();

                    Console.Write("Enter your age: ");
                    this.Age = int.Parse(Console.ReadLine());

                    Console.Write("Enter the name of a city: ");
                    this.City = Console.ReadLine();

                    Console.Write("Enter a country name: ");
                    this.Country = Console.ReadLine();

                    Console.Write("Enter the name of a profession: ");
                    this.Job = Console.ReadLine();

                    Console.Write("Enter an animal type: ");
                    this.Animal = Console.ReadLine();

                    Console.Write("Enter the name of the pet: ");
                    this.PetName = Console.ReadLine();
                }
                public void PrintMad()
                {
                    Console.WriteLine($"There once was a person named {this.Name} who lived in {this.City}. At the age of {this.Age}, {this.Name} decided to "
                        + $"move to {this.Country} and became a {this.Job}. Then, {this.Name} adopted a(n) {this.Animal} named {this.PetName}. They both lived happily ever after");
                }
            }//END OF MADLIBS

            public class Friend
            {
                private string userName, friendName;
                private int userAge, friendAge;

                public string UserName
                {
                    get;
                    set;
                }
                
                public string FriendName
                {
                    get;
                    set;
                }

                public int UserAge
                {
                    get;
                    set;
                }

                public int FriendAge
                {
                    get;
                    set;
                }

                public void GetNames()
                {
                    Console.Write("Enter your name: ");
                    this.UserName = Console.ReadLine();

                    Console.Write("Enter your Friend's name: ");
                    this.FriendName = Console.ReadLine();
                }

                public void GetAge()
                {
                    Console.Write("Enter your age: ");
                    this.UserAge = int.Parse(Console.ReadLine());

                    Console.Write("Enter your friend's age: ");
                    this.FriendAge = int.Parse(Console.ReadLine());
                }

                public void AgeDiff()
                {
                    Console.WriteLine($"Your name is {this.UserName} and you are {this.UserAge} years old");

                    Console.WriteLine($"Your friend's name is {this.FriendName} and they are {this.FriendAge} years old");
                    
                    Console.WriteLine($"There are {Math.Abs(this.UserAge - this.FriendAge)}");
                }
            }//END OF FRIEND CLASS
        }//END OF LAB 2

        public class Lab3
        {
            public class AverageScore
            {
                private double scoreTotal, average;

                public double ScoreTotal
                {
                    get
                    {
                        return this.scoreTotal;
                    }
                    set
                    {
                        this.scoreTotal = value;
                    }
                }
                public double Average
                {
                    get
                    {
                        return this.average;
                    }
                    set
                    {
                        this.average = value;
                    }
                }

                public void GetScoresAndCalc()
                {
                    int numScores;

                    Console.Write("How many scores would you like to add: ");
                    numScores = int.Parse(Console.ReadLine());

                    for(int i = 0; i < numScores; i++)
                    {
                        Console.Write($"Enter Score {i + 1}: ");
                        this.ScoreTotal += double.Parse(Console.ReadLine());
                    }

                    this.Average = this.ScoreTotal / (double)numScores;

                    Console.WriteLine($"Your average score is: {this.Average:F2} {(this.Average > 95 ? "That's a great score!" : "")} ");
                }
            }//END OF AVG SCORE

            public class AudioBooks
            {
                private char choice;
                private int numBooks;
                private double totalCharge;

                public char Choice
                {
                    get;
                    set;
                }

                public int BooksRead
                {
                    get
                    {
                        return this.numBooks;
                    }
                    set
                    {
                        this.numBooks = value;
                    }
                }

                public double TotalCharge
                {
                    get
                    {
                        return this.totalCharge;
                    }
                    set
                    {
                        this.totalCharge = value;
                    }
                }

                public void GetPackage()
                {
                    Console.Write("Enter the letter of your audiobooks package A, B, C: ");
                    this.Choice = char.ToUpper(char.Parse(Console.ReadLine()));
                }

                public void GetBooks()
                {
                    Console.Write("Enter the number of audio books you read: ");
                    this.BooksRead = int.Parse(Console.ReadLine());
                }

                public double MonthlyBill()
                {
                    double ans;

                    if ((this.Choice == 'C') && (this.BooksRead >= 0))
                    {
                        ans = PACKAGE_C_PRICE;
                    }
                    else if ((this.Choice == 'B') && (this.BooksRead > INCLUDED_B_BOOKS))
                    {
                        ans = PACKAGE_B_PRICE + (EXTRA_B_BOOKS * (this.BooksRead - INCLUDED_B_BOOKS));
                    }
                    else if ((this.Choice == 'B') && (this.BooksRead <= INCLUDED_B_BOOKS) && (this.BooksRead >= 0))
                    {
                        ans = PACKAGE_B_PRICE;
                    }
                    else if ((this.Choice == 'A') && (this.BooksRead > INCLUDED_A_BOOKS))
                    {
                        ans = PACKAGE_A_PRICE + (EXTRA_A_BOOKS * (this.BooksRead - INCLUDED_A_BOOKS));
                    }
                    else if ((this.Choice == 'A') && (this.BooksRead <= INCLUDED_A_BOOKS) && (this.BooksRead >= 0))
                    {
                        ans = PACKAGE_A_PRICE;
                    }
                    else
                    {
                        Console.WriteLine("You made an invalid choice for Audiobook package or entered a negative value for number of books read.\nPlease try again");

                        return 0;
                    }

                    return ans;
                }

                public void PrintBill()
                {
                    Console.WriteLine($"Total charges for {this.BooksRead} books for plan {this.Choice} is ${this.TotalCharge:F2}");
                }
            }//END OF AUDIOBOOKS

            public class Seasons
            {
                private string season;
                const string SPRING_SPANISH = "la primavera";
                const string SUMMER_SPANISH = "el Verano";
                const string AUTUMNFALL_SPANISH = "el otono";
                const string WINTER_SPANISH = "el invierno";

                public string Season
                {
                    get
                    {
                        return this.season; 
                    }
                    set
                    {
                        this.season = value;
                    }
                }

                public string GetSeason()
                {
                    Console.WriteLine("Enter the name of a season and I'll translate it to Spanish: ");

                    return Console.ReadLine();
                }

                public void TranslateSeason(string szn)
                {
                    switch(szn.ToUpper())
                    {
                        case "SPRING":
                            Console.WriteLine($"{szn.ToUpper()} in spanish is {SPRING_SPANISH}");
                            break;
                        case "SUMMER":
                            Console.WriteLine($"{szn.ToUpper()} in spanish is {SUMMER_SPANISH}");
                            break;
                        case "AUTUMN":
                            Console.WriteLine($"{szn.ToUpper()} in spanish is {AUTUMNFALL_SPANISH}");
                            break;
                        case "FALL":
                            Console.WriteLine($"{szn.ToUpper()} in spanish is {AUTUMNFALL_SPANISH}");
                            break;
                        case "WINTER":
                            Console.WriteLine($"{szn.ToUpper()} in spanish is {WINTER_SPANISH}");
                            break;
                        default:
                            Console.WriteLine($"{szn.ToUpper()} is an invalid season.");
                            break;
                    }

                    Console.WriteLine("Thank you for using my program!");
                }
            }//END OF SEASONS CLASS
        }//END OF LAB 3 CLASS

        public class Lab4
        {
            public class AudioBook4
            {          
                private char choice;
                private int numBooks;
                private bool validInput;
                private double totalCharge;

                public char Choice
                {
                    get;
                    set;
                }

                public int BooksRead
                {
                    get
                    {
                        return this.numBooks;
                    }
                    set
                    {
                        this.numBooks = value;
                    }
                }

                public double TotalCharge
                {
                    get
                    {
                        return this.totalCharge;
                    }
                    set
                    {
                        this.totalCharge = value;
                    }
                }

                public void GetPackage()
                {
                    do
                    {
                        Console.Write("Enter the letter of your audiobooks package A, B, C: ");
                        validInput = char.TryParse(Console.ReadLine(), out this.choice);

                        this.Choice = char.ToUpper(choice);

                        if (!validInput || !((this.Choice == 'A') || (this.Choice == 'B') || (this.Choice == 'C')))
                        {
                            Console.WriteLine("You made an invalid package choice. Please select A, B, or C: ");
                        }
                    } while(!validInput || !((this.Choice == 'A') || (this.Choice == 'B') || (this.Choice == 'C')));
                }

                public void GetBooks()
                {
                    do
                    {
                        Console.Write("Enter the number of audio books you read: ");
                        validInput = int.TryParse(Console.ReadLine(), out this.numBooks);

                        if (!validInput || this.numBooks < 0)
                        {
                            Console.WriteLine("You entered an invalid number of books. Please enter a number greater than or equal to 0");
                        }
                    } while (!validInput || this.numBooks < 0);
                }

                public double MonthlyBill()
                {
                    double ans = 0.0;

                    switch(this.Choice)
                    {
                        case 'A':
                            if (this.numBooks > INCLUDED_A_BOOKS)
                            {
                                ans = PACKAGE_A_PRICE + (EXTRA_A_BOOKS * (this.numBooks - INCLUDED_A_BOOKS));
                            }
                            else
                            {
                                ans = PACKAGE_A_PRICE;
                            }
                            break;
                        case 'B':
                            if (this.numBooks > INCLUDED_B_BOOKS)
                            {
                                ans = PACKAGE_B_PRICE + (EXTRA_B_BOOKS * (this.numBooks - INCLUDED_B_BOOKS));
                            }
                            else
                            {
                                ans = PACKAGE_B_PRICE;
                            }
                            break;
                        case 'C':
                            ans = PACKAGE_C_PRICE;
                            break;
                    }

                    return ans;
                }

                public void PrintBill()
                {
                    Console.WriteLine($"Total charges for {this.BooksRead} books for plan {this.Choice} is ${this.TotalCharge:F2}");
                }

            }//END OF AUDIOBOOK 4

            public class Sum
            {
                private int num1, num2, sum;

                public int FirstNum
                {
                    get
                    {
                        return this.num1;
                    }
                    set
                    {
                        this.num1 = value;
                    }
                }

                public int SecondNum
                {
                    get
                    {
                        return this.num2;
                    }
                    set
                    {
                        this.num2 = value;
                    }
                }
                
                public int SumVal
                {
                    get
                    {
                        return this.sum;
                    }
                    set
                    {
                        this.sum = value;
                    }
                }

                public void GetNums()
                {
                    Console.Write("Enter the first number: ");
                    this.FirstNum = int.Parse(Console.ReadLine());

                    Console.Write("Enter the second number: ");
                    this.SecondNum = int.Parse(Console.ReadLine());
                }

                public int GetSum()
                {
                    int ans;

                    ans = this.FirstNum + this.SecondNum;

                    return ans;
                }

                public void RunSum()
                {
                    char repeat;
                    do
                    {
                        GetNums();
                        this.SumVal = GetSum();

                        Console.WriteLine($"The sum of {this.FirstNum} and {this.SecondNum} is {this.SumVal}");

                        Console.WriteLine("Would you like to perform this operation again? If not press N");
                        repeat = char.ToUpper(char.Parse(Console.ReadLine()));
                    } while (repeat != 'N');
                }
            }//END OF SUM CLASS

            public class RunningTotal
            {
                private double total;

                public double Total
                {
                    get;
                    set;
                }

                public void CalcTotal()
                {
                    int numPrices;

                    Console.Write("I will keep a running total. How many prices would you like to enter: ");
                    numPrices = int.Parse(Console.ReadLine());

                    for(int i = 0; i < numPrices; i++)
                    {
                        Console.Write($"Enter price {i + 1}: $");
                        this.Total += double.Parse(Console.ReadLine());
                    }

                    Console.WriteLine($"The total amount is ${this.Total:F2}");
                }
            }//END OF RUNNING TOTAL CLASS

            public class Pyramid
            {
                private int pyramidHeight;

                public int PyramidHeight
                {
                    get;
                    set;
                }

                public void PrintPyramid()
                {
                    Console.Write("How tall do you want the pyramid to be: ");
                    this.PyramidHeight = int.Parse(Console.ReadLine());

                    for(int i = 0; i < this.PyramidHeight; i++)
                    {
                        int numStar = i + 1;
                        
                        while(numStar > 0)
                        {
                            Console.Write("*");
                            numStar--;
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
        public static string GetName()
        {
            string input;

            Console.Write("Enter your name: ");
            input = Console.ReadLine();

            return input;

        }
        private static Dictionary<int, string[]> Labs = new Dictionary<int, string[]>()
        {
            { 1, new string[] {"No Coding Labs" } },
            { 2, new string[] {"Wages", "Madlibs", "Friend"} },
            { 3, new string[] {"AverageScore", "Audiobooks", "Seasons"} },
            { 4, new string[] {"Audiobooks", "Sum", "RunningTotal", "Pyramid"}},
        };

        private static void Menu()
        {
            Console.WriteLine("Here is a menu of the Labs that are available: ");

            foreach (var kvp in Labs)
            {
                Console.WriteLine($"Lab {kvp.Key} Programs: ");
                foreach (string s in kvp.Value)
                {
                    Console.Write($"{s} ");
                }
                Console.WriteLine("\n");
            }
        }

        private static void ProgramChoice(int option)
        {
            Console.WriteLine("Here are your available programs");
            for (int i = 0; i < Labs[option].Length; i++)
            {
                Console.WriteLine($"Program {i + 1}: {Labs[option][i]}");
            }
        }

        private static int RunLab()
        {
            int x;
            Console.Write("Which program would you like to run: ");
            x = int.Parse(Console.ReadLine());

            return x;
        }

        static void Main(string[] args)
        {
            char repeatChar;
            int labChoice, progChoice;
            bool repeat;

            Console.WriteLine("Welcome to the CSCI 1250 Lab-i-nator.\nAll 1250 Labs involving Coding are accessible in this!");

            do
            {
                Menu();

                Console.Write("Which Lab would you like to run: ");
                labChoice = int.Parse(Console.ReadLine());

                switch(labChoice)
                {
                    case 1:
                        Console.WriteLine(Labs[labChoice][0]);
                        break;
                    case 2:
                        ProgramChoice(labChoice);
                        progChoice = RunLab();
                        Console.WriteLine($"You chose {Labs[labChoice][progChoice - 1]}");
                        switch (progChoice)
                        {
                            case 1:
                                Lab2.Wages wage = new Lab2.Wages(CSCI1250.GetName());
                                wage.GetPays();
                                wage.GetHours();
                                wage.TotalWage = wage.CalculateWage(wage.RegPay, wage.OTPay, wage.RegHours, wage.OTHours);
                                Console.WriteLine($"Total wages for {wage.Name} are: ${wage.TotalWage:F2}");
                                break;
                            case 2:
                                Lab2.Madlibs ml = new Lab2.Madlibs();
                                ml.GetLibs();
                                ml.PrintMad();
                                break;
                            case 3:
                                Lab2.Friend friend = new Lab2.Friend();
                                friend.GetNames();
                                friend.GetAge();
                                friend.AgeDiff();
                                break;                           
                        }
                        break;
                    case 3:
                        ProgramChoice(labChoice);
                        progChoice = RunLab();
                        Console.WriteLine($"You chose {Labs[labChoice][progChoice - 1]}");
                        switch (progChoice)
                        {
                            case 1:
                                Lab3.AverageScore AVG = new Lab3.AverageScore();
                                AVG.GetScoresAndCalc();
                                break;
                            case 2:
                                Lab3.AudioBooks AB3 = new Lab3.AudioBooks();
                                AB3.GetPackage();
                                AB3.GetBooks();
                                AB3.TotalCharge = AB3.MonthlyBill();
                                AB3.PrintBill();
                                break;
                            case 3:
                                Lab3.Seasons Szn = new Lab3.Seasons();
                                Szn.Season = Szn.GetSeason();
                                Szn.TranslateSeason(Szn.Season);
                                break;
                        }
                        break;
                    case 4:
                        ProgramChoice(labChoice);
                        progChoice = RunLab();
                        Console.WriteLine($"You chose {Labs[labChoice][progChoice - 1]}");
                        switch (progChoice)
                        {
                            case 1:
                                Lab4.AudioBook4 AB4 = new Lab4.AudioBook4();
                                AB4.GetPackage();
                                AB4.GetBooks();
                                AB4.TotalCharge = AB4.MonthlyBill();
                                AB4.PrintBill();
                                break;
                            case 2:
                                Lab4.Sum sum = new Lab4.Sum();
                                sum.RunSum();
                                break;
                            case 3:
                                Lab4.RunningTotal RT = new Lab4.RunningTotal();
                                RT.CalcTotal();
                                break;
                            case 4:
                                Lab4.Pyramid pyramid = new Lab4.Pyramid();
                                pyramid.PrintPyramid();
                                break;
                        }
                        break;                        
                }

                Console.Write("\nWould you like to do this again? If not enter N: ");
                repeatChar = char.ToUpper(char.Parse(Console.ReadLine()));

                repeat = repeatChar == 'N' ? false : true;
                Console.WriteLine();
            } while (repeat);
        }
    }
}