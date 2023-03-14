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


app.Run();
//TASK1
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





