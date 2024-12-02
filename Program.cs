using AdventOfCode2024;

Dictionary<string, IAnswer> solutions = new()
{
    { "1-1", new AdventOfCode2024.Solutions.Day_01_01.Answer() },
    { "1-2", new AdventOfCode2024.Solutions.Day_01_02.Answer() },
};

while (true)
{
    Console.Clear();
    Console.WriteLine("Choose one of the solutions below:");
    Console.WriteLine($"({string.Join(" | ", solutions.Keys)})");
    Console.Write("Solution:");
    string? input = Console.ReadLine();

    if (input is not null && solutions.ContainsKey(input))
    {
        Console.WriteLine(solutions[input].PrintAnswer);
    }

    Console.Write("\nPress any key to continue...");
    Console.ReadKey();
}