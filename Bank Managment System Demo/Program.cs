using Bank_Managment_System_Demo;

Customer c1 = new Customer("Ali", 123456, 5000);
Customer c2 = new Customer("Asif", 654321, 10000);
Customer c3 = new Customer("Arif", 456321, 15000);
Console.WriteLine("========Customer Information========");
Console.WriteLine();
Bank b1 = new Bank();
c1.Displayinfo();
b1.OpenAccount(c1);
Console.WriteLine();
c2.Displayinfo();
b1.OpenAccount(c2);
Console.WriteLine();
c3.Displayinfo();
b1.OpenAccount(c3);
Console.WriteLine();
Console.WriteLine("==========List of Customers==========");
b1.ShowCustomer();
Console.WriteLine();
Console.WriteLine("==========Search Customer by Account Number==========");
b1.SearchCustomer(654321);
Console.WriteLine();
Console.WriteLine("==========Deposit Amount in Customer Account==========");
b1.Deposit(123456, 5000);
Console.WriteLine();
Console.WriteLine("==========Withdraw Amount from Customer Account==========");
b1.Withdraw(456321, 2000);
Console.WriteLine();
Console.WriteLine("==========Remove Customer Account==========");
b1.ShowBalance(123456);
Console.WriteLine();
Console.WriteLine("==========Total Money in Bank==========");
b1.Totalmoneyinbank();
Console.WriteLine();
Console.WriteLine("==========Lowest Balance Customer==========");
b1.LowestBalance();







//c1.Displayinfo();
//Console.WriteLine();
//c2.Displayinfo();
//Console.WriteLine();
//c3.Displayinfo();



