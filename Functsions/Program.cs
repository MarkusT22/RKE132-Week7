Console.WriteLine("Are you coming or leaving? (in/out):");
string userChoice = Console.ReadLine();

if(userChoice == "in") 
{
    PrintHello();
}
else 
{
    PrintGoodBye();
}



static void PrintHello() //Function / Method
{
    Console.WriteLine("Hello world!");
}

static void PrintGoodBye() 
{
    Console.WriteLine("See you later, aligator.");
}
