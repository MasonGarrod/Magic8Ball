using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic8Ball_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Magic 8 Ball \\
            Console.WriteLine("Magic 8 Ball");

            // Delcare Variables \\
            Random rng = new Random(); // Creates a random number generator \\
            List<string> answers = new List<string>(); // Creates new array called 'answers' \\
            int index;
            string question;
            int num;

            // User enters if they want to exit the Magic 8 Ball \\
            Console.Write("Would you like to end the magic 8 ball (type 'end' if not press any key): ");
            question = Console.ReadLine();

            // Positive = 8 \\
            answers.Add("Yes.");
            answers.Add("Indeed.");
            answers.Add("Without a doubt.");
            answers.Add("It is certain.");
            answers.Add("You may rely on it.");
            answers.Add("It is decidedly so.");
            answers.Add("Signs point to yes.");
            answers.Add("As I see it, yes.");

            // Neutral = 6 \\
            answers.Add("The reply is hazy, try again.");
            answers.Add("Ask again later.");
            answers.Add("Better not to tell you this now.");
            answers.Add("Cannot predict this at the moment.");
            answers.Add("You may need to concentrate and try again.");
            answers.Add("Probably.");

            // Negative = 6 \\
            answers.Add("Don't count on it.");
            answers.Add("My reply is no.");
            answers.Add("My sources say no.");
            answers.Add("Very doubtful.");
            answers.Add("Outlook not so good.");
            answers.Add("Most definitely not.");

            // Chooses a random output from the array 'answers' \\
            while (question.ToUpper() != "END")
            {
                // User enters a question that must be answered with a yes or no \\
                Console.ResetColor();
                Console.Write("Enter a question which must be yes or no, or type 'end' to exit: ");
                question = Console.ReadLine();

                // Validates the input \\
                while (question == "")
                {
                    Console.ResetColor();
                    Console.WriteLine("Invalid input, try again.");
                    Console.Write("Enter a question which must be yes or no: ");
                    question = Console.ReadLine();
                }

                // User exits if 'end' is inputted \\
                if (question == "end")
                {
                    break;
                }

                // Counts the answers and gives answers a colour \\
                num = index = rng.Next(0, answers.Count);

                // Positives \\
                if (num < 8)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }

                // Neutral \\
                else if (num < 14)
                {
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }

                // Negatives \\
                else
                {
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                // Display Answer \\
                Console.WriteLine(answers[index]);

            }

            // Exit \\
            Console.Write("Press any key to exit: ");
            Console.ReadKey();

        }
    }
}
