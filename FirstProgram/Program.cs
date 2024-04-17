using System;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("And the journey begins!");
            Console.WriteLine("I am Nabil!");

            //This is a comment

            //variable declaration
            int x = 2000; //decla_initi
            int y = 2024; //decla_initi

            int z = y - x;
            bool male = true;
            string home = "Dhaka";

            //type casting (converting datatypes)
            double a = 24.56;
            int b = Convert.ToInt32(a);

            Console.WriteLine("My age is " + z);
            Console.WriteLine("Are you a male? " + male);
            Console.WriteLine("I am from " + home);
            Console.WriteLine("Converted data: " + b); //use getType() for knowing the data type


            //user inputs

            //Console.WriteLine("Please type your name below- "); //accepting user input
            //string name = Console.ReadLine(); //accepting user input

            //Console.WriteLine("And your age? ");
            //int age= Convert.ToInt32(Console.ReadLine()); //converting user input to int

            //Console.WriteLine("Nice to meet you " + name + ". And you are " + age + " years old.");

            //to increment use x++(only 1) or x+=(any number you want)

            //generating random numbers
            Random randomNum = new Random();
            int num = randomNum.Next(1, 7);
            Console.WriteLine(num);


            //calculating triangle hypotenuse

            //taking and converting user input for sideA

            /*Console.WriteLine("Provide side A below- ");
            double sideA=Convert.ToDouble(Console.ReadLine());

            //taking and converting user input for sideB
            Console.WriteLine("Provide side B below- ");
            double sideB = Convert.ToDouble(Console.ReadLine());

            //calculating using formula
            double hyPoTenuse=Math.Sqrt((a*a)+(b*b));
            Console.WriteLine("Calculated hypotenuse: " + hyPoTenuse);
            */

            //string methods
            string name = "Nabil Shartaz Khan";
            string phoneNumber = "1-7704-384-40";
            name = name.ToUpper();
            phoneNumber = phoneNumber.Replace("-", ""); //first the to be replaced string then the replacement

            string BdNum = phoneNumber.Insert(0, "+880"); //inserting in first index 

            //subString extracts the given portion of a string, suppose 0,3 here 0 means first index and 3 means 3 characters after that index.


            Console.WriteLine("Upper cased name- " + name); //similarly you can use ToLower();
            Console.WriteLine("Replaced number- " + phoneNumber);
            Console.WriteLine("Bangladeshi number is- " + BdNum);


            //if-else statements

            /*Console.WriteLine("What is your age? ");

            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18 && age <= 70)
            {
                Console.WriteLine("Congratulations");
            }
            else if (age > 70)
            {
                Console.WriteLine("Not a valid age!");
            }
            else
            {
                Console.WriteLine("GET OUT!");
            }
            */

            //switches (alternative for if else)
            /*Console.WriteLine("What day is it today? ");

            string day = Console.ReadLine();

            switch (day) {

                case "Monday":
                    Console.WriteLine("Yay its monday!");
                    break;
                case "Sunday":
                    Console.WriteLine("Yay its Sunday!");
                    break;
                default:
                    Console.WriteLine("Maybe you wrote a day but i didn't write switch code for it");
                    break;
            }
            */

            //while loop
            /*string newName = "";
            while (newName == "")
            {
                Console.WriteLine("Enter your name: ");
                newName = Console.ReadLine();
            }
            Console.WriteLine("Nice to meet you " + newName);
            */


            //nested loops example 
            /*Console.Write("How many rows?: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("How many columns?: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            Console.Write("Choose symbol: ");
            String symbol = Console.ReadLine();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
            */

            //arrays
            //declaring
            string[] cars = { "BMW", "Ferrari", "Mercedes", "Chevrolet" };

            //accessing
            Console.WriteLine("Accessed data: " + cars[0]);

            //change index
            cars[0] = "Lambhorgini";
            //accessing
            Console.WriteLine("Changed accessed data: " + cars[0]);

            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }

            // Call the sayMyName method
            sayMyName();

            /*double result;

            Console.WriteLine("Enter number 1- ");
            double num1=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter number 2- ");
            double num2=Convert.ToDouble(Console.ReadLine());

            result=Multiply(num1, num2);

            Console.WriteLine("Multiplied result is- "+result);
            */

            double total = Checkout(2.55, 6.58, 7.24, 8.95, 1.24);
            Console.WriteLine("You have to pay: " + total);



            //trying out conditional operators
            double temperature = 20.56;
            string manName = "Nabil";
            int age = 21;

            string message = (temperature >= 19) ? "It is okay to go outside" : "It is cold outside";
            Console.WriteLine(message);


            //string interpolation
            Console.WriteLine($"Nice to meet you {manName}. You are {age} years old.");


            Messages.Hello();
            Messages.Work();
            Messages.Bye();

            Console.ReadKey(); //for removing garbages


        }

        static void sayMyName()
        {
            Console.WriteLine("********creating Method**********");
            Console.WriteLine("Your name is what you are!");
            Console.WriteLine("Oh you are really special");
            Console.WriteLine("I love the way you are");
            Console.WriteLine("********Method created**********");
        }

        static double Multiply( double x, double y) {
            return x * y;  //returns the data where it is called
        }

        static double Checkout( params double[] prices) {   //params is used for unknown number of arguments
            double total = 0;
            foreach (double price in prices) {
                total= total + price;
            }
            return total;
        }




    }
}
