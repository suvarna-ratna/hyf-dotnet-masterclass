var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

//Caclulator
app.MapGet("/calc", (string numberOne,string numberTwo,string operation) => 
{
    var numberOneIsValid = int.TryParse(numberOne, out var parsedNumberOne);
     var numberTwoIsValid = int.TryParse(numberTwo, out var parsedNumberTwo);

     if(!numberOneIsValid|| !numberTwoIsValid){
         Results.BadRequest("one of the two numbers is not valid");
     }
     int result;
     switch(operation)
     {
case "add":

result = parsedNumberOne+parsedNumberTwo;
break;
case "subtract":
result = parsedNumberOne-parsedNumberTwo;
break;
case "multiply":
result = parsedNumberOne*parsedNumberTwo;
break;





     }
});


app.Run();
