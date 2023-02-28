var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// String Manipulation
app.MapGet("/manipulation", (string input) => ReverseString(input));

string ReverseString(string inputString)
{
    char[] charArray = inputString.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}

string input = "world";
string reversed = ReverseString(input); //TODO: Implement ReverseString
Console.WriteLine($"Reversed input value: {reversed}");

// String/Math
app.MapGet("/math", (string input1) => GetVowelCount(input1));

 int GetVowelCount(string inputString)
{
    int count = 0;
    string vowels = "aeiouAEIOU";

    foreach (char c in inputString)
    {
        if (vowels.Contains(c))
        {
            count++;
        }
    }

    return count;
}

string input1 = "Intellectualization";
int vowelCount = GetVowelCount(input1); //TODO: Implement GetVowelCount
Console.WriteLine($"Number of vowels: {vowelCount}");
//Math/Array
app.MapGet("/math-array", ( int[] arr ) => GetResult(arr));
int[] GetResult(int[] arr)
{
    
    int negativeSum = 0;
    int positiveProd = 1;

    foreach (int num in arr)
    {
        if (num < 0)
        {
            negativeSum += num;
        }
        else if (num > 0)
        {
            positiveProd *= num;
        }
    }

    return new int[] { negativeSum, positiveProd };

}
int[] arr = new[] { 271, -3, 1, 14, -100, 13, 2, 1, -8, -59,  -1852, 41, 5 };
int[] result = GetResult(arr); //TODO: Implement GetResult
Console.WriteLine($"Sum of negative numbers: {result[0]}. Multiplication of positive numbers: {result[1]}");
// Classical task
app.MapGet("/fibonacci", ( int n) => Fibonacci(n));
int Fibonacci(int n)

{
 if (n <= 1)
    {
        return n;
    }

    int prev1 = 0, prev2 = 1, fib = 0;

    for (int i = 2; i <= n; i++)
    {
        fib = prev1 + prev2;
        prev1 = prev2;
        prev2 = fib;
    }

    return fib;
}
int n = 6;
int nthNumber = Fibonacci(n); //TODO: Implement Fibonacci
Console.WriteLine($"Nth fibonacci number is {nthNumber}");

app.Run();
