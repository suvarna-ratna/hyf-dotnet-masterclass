var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
// You can use any of the following:
var ash = new Person();
var mauve = new Person { Name = "Mauve" };
Person xavier = new Person() { Name = "Xavier", Id = 3 };
Person santos = new Person
{
    Id = 1,
    Name = "Santos"
};
app.Run();
public class Person
{
	public int Id { get; set; }
	public string Name { get; set; }
  public string AddressLine { get; set; }
  public string City { get; set; }
}

//Create a class named Temperature and make a constructor with one decimal parameter - degrees (Celsius) and assign its value to Property. The property has a public getter and private setter. The property setter throws an exception if temperature is less than 273.15 Celsius. Then, create a property Fahrenheit that will convert Celsius to Fahrenheit (it has no setter similar to NicePrintout)
 var temperature = new Temperature(10);
 console.WriteLine($"{temperature.Celsius} Celsius is {temperature.Fahrenheit} Fahrenheit");
public class Temperature
{
  public int Celsius { get; set; }
  

  public Temperature(int Celsius )
	{
		Celsius = 10;
	}
}