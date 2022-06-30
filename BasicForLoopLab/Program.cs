string answer;


do
{
    int sum = 0;

    Console.Write("Hello! Please enter a number: ");
    int input = int.Parse(Console.ReadLine());

    for (int i = 1; i <= input; i++)
    {
        sum += i;
    }

    Console.Write("\n" + sum);

    Console.Write("\n\nWould you like to try again? y/n: \n");
    answer = Console.ReadLine();
} while (answer == "y");

if (answer == "n")
{
    Console.WriteLine("\nGoodbye!");
}


Console.ReadKey();