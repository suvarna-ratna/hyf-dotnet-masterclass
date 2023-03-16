var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/account", () =>
{
    var account = new Account(1000);
    account.Deposit(100);
    Console.WriteLine($"Account balance is {account.Balance}");
    account.Withdraw(20);
    Console.WriteLine($"Account balance is {account.Balance}");
    account.Withdraw(200); // ❌ we should not be able to withdraw more than we have in the balance
    return account.Balance;
});
app.MapGet("/animal_sound", () =>
{
    var cat = new Cat();
    var dog = new Dog();
    var cow = new Cow();
    var sound = new Sound();
    var animal1 = sound.MakeSound(cat);
    var animal2 = sound.MakeSound(dog);
    var animal3 = sound.MakeSound(cow);
    return ($"{animal1}, {animal2}, and {animal3}");

});



app.Run();
//TASK1
/* Create Account class that can be initialized with the amount value. Account class contains 
Withdraw and Deposit methods and Balance (get only) property. Make sure that you 
can't withdraw more than you have in the balance. */
public class Account
{
    public double Amount { get; set; }
    public Account(double initialamount)
    {
        Amount = initialamount;
    }
    public double _balance;
    public double Balance { get => _balance; }
    public double Deposit(double deposit)
    {
        double result = Amount + deposit;
        this._balance = result;
        return result;
    }
    public double Withdraw(double withdraw)
    {
        if (withdraw > _balance)
        {
            throw new Exception("you can't withdraw more than your balance");
        }
        double result = Balance - withdraw;
        this._balance = result;
        return result;
    }
}

//TASK2
/* Create interface IAnimal with property Name and Sound. Create classes Cow, Cat and Dog that implement IAnimal. 
Instantiate all three classes and pass them to a new method called MakeSound that has single parameter IAnimal 
and it writes to console eg “Dog says woof woof” if instance of the Dog class is passed. */
public interface IAnimal
{
    string Name { get; }
    string Sound { get; }
}

public class Cow : IAnimal
{
    public string Name { get; } = "Cow";
    public string Sound { get; } = "moo-moo";
}

public class Cat : IAnimal
{
    public string Name { get; } = "Cat";
    public string Sound { get; set; } = "meow-meow";
}

public class Dog : IAnimal
{
    public string Name { get; } = "Dog";
    public string Sound { get; } = "bow-wow";
}

class Sound
{
    public string MakeSound(IAnimal animal)
    {
        return ($"{animal.Name} says {animal.Sound} ");
    }

}






