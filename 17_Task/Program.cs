Console.WriteLine("Введите номер счёта: ");
BankAccount<string> numberAccount1 = new BankAccount<string>(Console.ReadLine(), 4684415, "Иванов Пётр Александрович");
numberAccount1.ShowInfo();
Console.WriteLine(numberAccount1);
Console.WriteLine("Введите номер счёта: ");
BankAccount<int> numberAccount2 = new BankAccount<int>(Convert.ToInt32(Console.ReadLine()), 214748364, "Кузнецов Сергей Владимирович");
numberAccount2.ShowInfo();
Console.WriteLine(numberAccount2);
class BankAccount<T>
{

    public T NumberAccount { get; set; }
    public int Balance { get; set; }
    public string NameOfOwner { get; set; }
    public BankAccount(T numberAccount, int balance, string nameOfOwner)
    {
        NumberAccount = numberAccount;
        Balance = balance;
        NameOfOwner = nameOfOwner;
       
    }
    public void ShowInfo()
    {
        Console.WriteLine("Баланс: {0} рублей. ФИО владельца счёта: {1}", Balance, NameOfOwner);
    }
}