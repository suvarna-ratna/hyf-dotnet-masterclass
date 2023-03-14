var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapGet("/", () => "hi idiot");
app.MapGet("/account", () =>
{
    var account = new Account(5000);
    account.Withdraw(2000);
    account.Deposit(1000);
    return account.Balance;
});

app.Run();
//withdraw:
// Create Account class that can be initialized with the amount value. 
// Account class contains Withdraw and Deposit methods and Balance (get only) property.
//  Make sure that you can't withdraw more than you have in the balance.
public class Account
{
  public double Amount { get; set; }
  public Account(double initialAmount)
  {
    Amount = initialAmount;
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
      throw new Exception("you can't withdraw more than you have in the balance");
    }
    double result = Balance - withdraw;
    this._balance = result;
    return result;
  }
}

