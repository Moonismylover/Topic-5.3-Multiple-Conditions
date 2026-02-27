using System.ComponentModel.Design;
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

            && is the 'and' operator, which means that both conditions must be true for the whole statement to be true.
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
            int guesses;

            Console.WriteLine(" ");
            Console.Write("How many guesses did you take? \nEnter here: ");
            guesses = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
            Console.Write("Enter the password: ");
            password = Console.ReadLine();  
            Console.WriteLine(" ");

            if (guesses <= 5 && password == "santa")
                Console.WriteLine("Open Sesame.");
            else 
                Console.WriteLine("Access Denied.");

            // Task 3

            string topping;

            /*
            We can sometimes use multiple comparisons in a single if statement. 

            if topping == "pepperoni" or topping == "mushrooms" 
            if (topping == "pepperoni" || topping == "mushrooms")

            || is the 'or' operator, which means that if either condition is true, the whole statement will be true.
            */

            Console.WriteLine(" ");
            Console.Write("What is your favorite pizza topping? \nEnter here: ");
            topping = Console.ReadLine().ToLower();
            Console.WriteLine(" ");

            if (topping == "olives" || topping == "onions" || topping == "mushrooms")
                Console.WriteLine("YUM! I love those that topping too!");
            else if (topping == "pineapple")
                Console.WriteLine("Pineapple on pizza? That's a controversial choice!");
            else 
                Console.WriteLine("Oh, that's a nice topping! I like that one too!");

            // Task 4

            int userAge;

            Console.WriteLine(" ");
            Console.Write("Enter your age: ");
            userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");

            if (age <= 60 || age <= 12)
                Console.WriteLine("The bus fare for you is $2.00");
            else 
                Console.WriteLine("The bus fare for you is $3.50");

        }
    }
}
