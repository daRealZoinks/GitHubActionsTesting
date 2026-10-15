using GitHubActionsTesting;

Console.WriteLine("Welcome to calculator!");

while (true)
{
    Console.WriteLine("Choose what you wanna do:");
    Console.WriteLine(string.Empty);
    Console.WriteLine("Add");
    Console.WriteLine("Subtract");
    Console.WriteLine("Exit");

    var input = Console.ReadLine() ?? string.Empty;

    if (input == "Add" || input == "Subtract")
    {
        Console.Write("Number 1: ");
        if (int.TryParse(Console.ReadLine(), out var number1))
        {
            Console.Write("Number 2: ");
            if (int.TryParse(Console.ReadLine(), out var number2))
            {
                if (input == "Add")
                {
                    Console.WriteLine($"Result:{Calculator.Add(number1, number2)}");
                }
                else if (input == "Subtract")
                {
                    Console.WriteLine($"Result:{Calculator.Subtract(number1, number2)}");
                }
            }
        }
    }
    else if (input == "Exit")
    {
        break;
    }
    else
    {
        Console.WriteLine("Thats not a command");
    }
}

Console.WriteLine("Bye!");