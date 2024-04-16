// See https://aka.ms/new-console-template for more information

//whatever i am learning c#, thanks to brocode https://www.youtube.com/@BroCodez

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
int b=Convert.ToInt32(a);

Console.WriteLine("My age is "+z);
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
int num= randomNum.Next(1, 7);
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
phoneNumber=phoneNumber.Replace("-", ""); //first the to be replaced string then the replacement

string BdNum = phoneNumber.Insert(0, "+880"); //inserting in first index 

//subString extracts the given portion of a string, suppose 0,3 here 0 means first index and 3 means 3 characters after that index.


Console.WriteLine("Upper cased name- "+name); //similarly you can use ToLower();
Console.WriteLine("Replaced number- " + phoneNumber);
Console.WriteLine("Bangladeshi number is- " + BdNum);


//if-else statements

Console.WriteLine("What is your age? ");

int age = Convert.ToInt32(Console.ReadLine());

if (age >= 18)
{
    Console.WriteLine("Congratulations");
}
else if (age < 0)
{
    Console.WriteLine("Not a valid age!");
}
else {
    Console.WriteLine("GET OUT!");
}





Console.ReadKey(); //for removing garbages


