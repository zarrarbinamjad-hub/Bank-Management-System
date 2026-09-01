using Bank_Managment_System_Demo;

Customer c1 = new Customer("Ali", 123456, 5000);
Customer c2 = new Customer("Asif", 654321, 10000);
Customer c3 = new Customer("Arif", 456321, 15000);
c1.Displayinfo();
c2.Displayinfo();
c3.Displayinfo();

Bank b1 = new Bank();
b1.OpenAccount(c1);
b1.OpenAccount(c2);
b1.OpenAccount(c3);
Console.WriteLine();
b1.ShowCustomer();
Console.WriteLine();
b1.SearchCustomer(654321);
Console.WriteLine();
b1.Deposit(123456, 5000);
Console.WriteLine();
b1.Withdraw(456321, 2000);
Console.WriteLine();
b1.ShowBalance(123456);
Console.WriteLine();
b1.Totalmoneyinbank();
Console.WriteLine();
b1.LowestBalance();




