using System.Data.SqlTypes;

namespace Topic_5._3__Multiple_Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;

            Console.Title = "Topic 5.3 ~Multiple Conditions";

            /*
            In order to compare two numberical values, we can use the following boolen operator.
            
            if age >= 13 and age <= 19
            if age >= 13 && age <= 19

            */

            Console.Write("Enter your age: "); 
            age = Convert.ToInt32(Console.ReadLine());

            if (age >= 13 && age <= 19)
            {
                Console.WriteLine("You are a teenager.");
            }
            else
            {
                Console.WriteLine("You are not a teenager.");
            }

            Console.WriteLine(" ");

            // Task 1

            double money;
            string workingStatus;

            Console.Write("Hey! Let's go see a movie together! How much money do you have? \nEnter here: ");
            money = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");

            if (money >= 20.00)
            {
                Console.Write("Great! Are you gonna be working on Friday evening? \nEnter here (yes or no): ");
                workingStatus = Console.ReadLine().ToLower();
                Console.WriteLine(" ");

                if (workingStatus == "no")
                    Console.WriteLine("Awesome! Then I will see you tomorrow!");
                else 
                    Console.WriteLine("Oh, that's too bad. Maybe we can go another time.");
            }
            else 
                Console.WriteLine("Oh, that's too bad. Maybe we can go another time.");

            // Task 2

            string password;

            Console.WriteLine(" ");
            Console.Write("Hey! Guess the password! \nEnter here: ");
            password = Console.ReadLine();
            Console.WriteLine(" ");

            if (password != )



        }
    }
}
