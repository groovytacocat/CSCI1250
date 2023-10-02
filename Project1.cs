/**
*--------------------------------------------------------------------
* File name: Project1.cs
* Project name: Project1
* Solution name: Project1
*--------------------------------------------------------------------
* Author’s name and email: Adam Hooven, hoovenar@etsu.edu
* Course-Section: CSCI 1250
* Creation Date: 10/2/2023
* Modified Date: 10/2/2023
* -------------------------------------------------------------------
*/

namespace Project1;

class Project1
{
    const int NUM_QUESTIONS = 5;
    const int MAX_QUESTIONS = 10;

    static string[] questionBank = new string[]
    {
        //q1
        "Which of the following CANNOT be a variable type?" +
        "\nA. int" +
        "\nB. string" +
        "\nC. A Class name" +
        "\nD. All of the above",
        //q2
        "A for-each loop provides definite iteration: the count that the loop body will be executed depends on the size of the collection.  " +
        "An example of indefinite iteration is a(n)" +
        "\nA. if statement" +
        "\nB. package" +
        "\nC. collection" +
        "\nD. while loop",
        //q3
        "Testing should be _____________, meaning that a specific approach is used to help localize the problem." +
        "\nA. Top-Down" +
        "\nB. Systematic" +
        "\nC. Bottom-up" +
        "\nD. Progressive",
        //q4
        "Tests that exercise only individual parts is/are called ___________." +
        "\nA. Case Test" +
        "\nB. Function Analysis" +
        "\nC. Group Test" +
        "\nD. Unit Test",
        //q5
        "What is the correct way to assign a value to the first element of an array in C#?" +
        "\nA. numbers[-1] = 10;" +
        "\nB. numbers[1] = 10;" +
        "\nC. numbers[2] = 10;" +
        "\nD. numbers[0] = 10;",
        //q6
        "Which of the following correctly initializes an array with values during declaration?" +
        "\nA. char[] letters = new char();" +
        "\nB. string names[] = new string[];" +
        "\nC. double prices = {1.99, 3.49, 2.79}" +
        "\nD. int[] numbers = new int[5]",
        //q7
        "What is an array in programming?" +
        "\nA. An object that can store a group of values, all of the same type" +
        "\nB. A data structure used for sorting data" +
        "\nC. A container that can store multiple values of different data types" +
        "\nD. A variable that can hold only one value at a time",
        //q8
        "A(n) ____ stores data used in a program." +
        "\nA. Boolean" +
        "\nB. Entity" +
        "\nC. Variable" +
        "\nD. Data type",
        //q9
        "In the following, what value is stored in x? int x = 5 / 2;" +
        "\nA. 3" +
        "\nB. 2" +
        "\nC. 2.5" +
        "\nD. Nothing, it causes an error",
        //q10
        "The if-else statement in C# executes which block of code when the boolean expression is false?" +
        "\nA. The \"if\" block" +
        "\nB. The \"else\" block" +
        "\nC. Both \"if\" and \"else\" blocks" +
        "\nD. None of the above",
    };

    static char[] answerBank = new char[]
    {
        'D',
        'D',
        'B',
        'D',
        'D',
        'C',
        'A',
        'C',
        'B',
        'B'
    };

    public static List<int> LoadQuestions(List<int> userQuestions)
    {
        Random rNum = new Random();

        int questionNum;

        while (userQuestions.Count < NUM_QUESTIONS)
        {
            questionNum = rNum.Next(0, 10);

            if (!userQuestions.Contains(questionNum))
            {
                userQuestions.Add(questionNum);
            }
        }

        return userQuestions;
    }

    public static List<char> LoadAnswers(List<char> userAnswers, List<int> userQuestions)
    {
        for(int i = 0; i < userQuestions.Count; i++)
        {
            userAnswers.Add(answerBank[userQuestions[i]]);
        }

        return userAnswers;
    }

    public static void PrintQuestion(List<int> userQuestion, int questionNum)
    {
        Console.WriteLine($"Question #{questionNum + 1} is:\n{questionBank[userQuestion[questionNum]]}"); 
    }

    static void Main(string[] args)
    {
        List<int> quiz = new List<int>();
        List<char> ans = new List<char>();
        char ansChoice;
        bool validInput;
        int score = 0;

        LoadQuestions(quiz);

        LoadAnswers(ans, quiz);

        for(int i = 0; i < quiz.Count; i++)
        {

            do
            {
                PrintQuestion(quiz, i);
                Console.Write("Enter your answer choice (A, B, C, D): ");
                validInput = char.TryParse(Console.ReadLine(), out ansChoice);

                ansChoice = char.ToUpper(ansChoice);

                if(!(ansChoice == 'A' || ansChoice == 'B' || ansChoice == 'C' || ansChoice == 'D'))
                {
                    validInput = false;
                }
                if (!validInput)
                {
                    Console.WriteLine("You made an invalid choice. Please select A, B, C, or D");
                }
                else
                {
                    if (ansChoice.Equals(ans[quiz[i]]))
                    {
                        Console.WriteLine("Correct! ");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"Incorrect! You entered {ansChoice}. The Correct answer was: {ans[quiz[i]]}");
                    }
                }
            } while (!validInput);
        }

    }
}

