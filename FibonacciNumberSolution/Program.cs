static long CalFibonacci(int n, long[]? resultCache = null)
{
    if (resultCache == null)
    {
        resultCache = new long[n + 1];
    }
    if (resultCache[n] != 0)
    {
        return resultCache[n];
    }

    if (n < 2) return 1;

    resultCache[0] = 1;
    resultCache[1] = 1;

    var result = CalFibonacci(n - 1, resultCache) + CalFibonacci(n - 2, resultCache);
    resultCache[n] = result;
    return result;
}

string exitCommand = "exit";

while (true)
{
    Console.WriteLine("Enter the number which you want result or type 'exit' to quit:");
    string input = Console.ReadLine();

    if (input.ToLower() == exitCommand) break;

    var inputCheck = int.TryParse(input, out int numInput);
    if (!inputCheck || numInput < 0)
    {
        Console.WriteLine("Wrong Input. The value must be integer greater than 0");
        continue;
    }
    var result = CalFibonacci(numInput);

    Console.WriteLine($"The result is {result}");
}
