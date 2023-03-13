var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

//Caclulator
app.MapGet("/calc", (string numberOne,string numberTwo,string operation) =>CalcFun(numberOne,numberTwo,operation));
string CalcFun(string numberOne,string numberTwo,string operation)
{
    var numberOneIsValid = int.TryParse(numberOne, out var parsedNumberOne);
    var numberTwoIsValid = int.TryParse(numberTwo, out var parsedNumberTwo);

    if(!numberOneIsValid || !numberTwoIsValid){
        return "one of the two numbers is not valid";
    }
    else {
        int result;
        switch(operation)
        {
            case "add":
                result = parsedNumberOne+parsedNumberTwo;
                return Convert.ToString(result);
            case "subtract":
                result = parsedNumberOne-parsedNumberTwo;
                return Convert.ToString(result);
            case "multiply":
                result = parsedNumberOne*parsedNumberTwo;
                return Convert.ToString(result);
        }   
    }
    return "";

}
// word frequency
    string input = "The quick brown fox Jumps over the lazy dog";

app.MapGet("/wordfrequency", () => CountWordFrequency(input));

static Dictionary<string, int> CountWordFrequency(string text)
    {
    var words = text?.ToLower().Split(' ', System.StringSplitOptions.RemoveEmptyEntries);
    var wordFrequency = new Dictionary<string, int>();

    if (words != null)
    {
        foreach (var word in words)
        {
            if (wordFrequency.ContainsKey(word))
            {
                wordFrequency[word]++;
            }
            else
            {
                wordFrequency[word] = 1;
            }
        }
    }

    return wordFrequency;
    }

var wordFrequency = CountWordFrequency(input);
foreach (var res in wordFrequency)
{
    Console.WriteLine("{0}: {1}", res.Key, res.Value);
}
app.Run();

