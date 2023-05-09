Console.WriteLine("Number Analyzer");
Console.WriteLine();
Console.WriteLine("Please enter your name:");
string name = Console.ReadLine();

bool runProgram = true;

while (runProgram)
{
    int number = 0;
    while (number <= 0 || number > 100)
    {
        Console.WriteLine("Please enter an integer between 1 and 100");
        number = int.Parse(Console.ReadLine()); 

    }
    if (number % 2 ==1 && number <60)
    {
        Console.WriteLine(name + " You entered an odd number that is under 60");
    }
    else if (number %2 ==0 && number <25)
    {
        Console.WriteLine(name + " You enter an even number that is less that 25");
    }
    else if(number %2 ==0 && number >= 26 && number <= 60)
    {
        Console.WriteLine(name + " You entered an even number between 26 and 60 inclusive");
    }
    else if(number %2 ==0 && number > 60)
    {
        Console.WriteLine(name + " You entered an even number between 60 and 100");
    }
    else
    {
        Console.WriteLine(name + " You entered a number that is odd and between 60 and l00");
    }
    while (true)
    {
        Console.WriteLine("Do you want to continue? y/n");
        string choice = Console.ReadLine().Trim().ToLower();

        if (choice == "y")
        {
            runProgram = true;
            break;
        }
        else if (choice == "n")
        {
            runProgram = false;
            break;
        }
    }

}
