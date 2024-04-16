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

Console.WriteLine("Please type your name below- "); //accepting user input
string name = Console.ReadLine(); //accepting user input

Console.WriteLine("And your age? ");
int age= Convert.ToInt32(Console.ReadLine()); //converting user input to int

Console.WriteLine("Nice to meet you " + name + ". And you are " + age + " years old.");

//to increment use x++(only 1) or x+=(any number you want)

//generating random numbers




Console.ReadKey(); //for removing garbages


