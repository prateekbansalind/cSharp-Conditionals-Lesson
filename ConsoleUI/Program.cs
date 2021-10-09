using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName1 = "";
            firstName1 = "Prateek";
            Console.WriteLine(firstName1);

            //The above way of assigning a variable is called string literals.
            //We primarily want the data to be stored from either database, API or by user.

            //another example is to take a data from user

            string firstName = "";
            Console.Write("What is your first name: ");
            firstName = Console.ReadLine();

            //Conditionals
            //if statment 

            if (firstName == "prateek")
            {
                Console.WriteLine("Welcome, Mr. Bansal");
            }

            // in the above statment, if statment basically checks the true statment and if its true than it will run the statment which are present inside the block of if statment otherwise don't run what's inside the if statement.

            // Pro tip
            //in the if statment conditionals brackets, "==" means comparison whereas "=" means equality.

            string firstName2 = "";
            Console.Write("What is your name: ");
            firstName2 = Console.ReadLine();

            if (firstName2.ToLower() == "prateek")
            {
                Console.WriteLine("Hello, Mr. Bansal");
            }
            else
            {
                Console.WriteLine("Hello, another person.");
            }

            //in the above code, if statment can go alone but if you need to have else statement then it needs to go with if statment.
            //ToLower() is a method to convert any string alphabetical data into lower case.
            //usally methods in visual basic can be identified as purple box shown in the intellisense
            //whereas properties shown as white screw driver.
            //alos mehtods are in yellow color.


            // if - else if - else 

            string firstName3 = "";
            Console.Write("What is your name: ");
            firstName3 = Console.ReadLine();


            if (firstName3.ToLower() == "prateek")
            {
                Console.WriteLine($"Hello, {firstName3}");
            }
            else if (firstName3.ToLower() == "ram")
            {
                Console.WriteLine($"Hello, {firstName3}");
            }
            else
            {
                Console.WriteLine($"Hello {firstName3}, I don't know you.");
            }


            // if - else conditions with comparison operators

            Console.Write("what is your first name: ");
            string fName = Console.ReadLine();

            Console.Write("what is your last name: ");
            string lName = Console.ReadLine();

            if (fName.ToLower() == "prateek" && lName.ToLower() == "bansal")
            {
                Console.WriteLine($"Hello, {fName} {lName}");
            }
            else
            {
                Console.WriteLine($"Hello another {fName}");
            }


            // if else with multiple combination of conditonal checks

            Console.Write("what is your first name: ");
            string fName1 = Console.ReadLine();

            Console.Write("what is your last name: ");
            string lName1 = Console.ReadLine();

            if ((fName1.ToLower() == "prateek" && lName1.ToLower() == "bansal") || (fName1.ToLower() == "thomas" && lName1.ToLower() == "wayne"))
            {
                Console.WriteLine($"Hello, {fName} {lName}.");
            }
            else
            {
                Console.WriteLine("Do I know you?");
            }




            Console.WriteLine("Application Done!");


            Console.ReadLine();
        }
    }
}