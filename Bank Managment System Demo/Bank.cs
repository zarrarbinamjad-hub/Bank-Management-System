using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_Managment_System_Demo
{
    public class Bank
    {
        List<Customer> customers = new List<Customer>();

        public void OpenAccount(Customer customer)
        {
            customers.Add(customer);
            Console.WriteLine("Purpose of Account is : Personal Saving: " + customer.Name);
            Console.WriteLine("Your Current Account has been Open");
        }
        public void ShowCustomer()
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Name);
            }
        }
        public void SearchCustomer(int accountnumber)
        {
            foreach (Customer customer in customers)
            {
                if (accountnumber == customer.Accountnumber)
                {
                    Console.WriteLine("Customer Name is : " + customer.Name);
                }
            }
        }
        public void Deposit(int accountnumber, double amount)
        {
            foreach (Customer customer in customers)
            {
                if (customer.Accountnumber == accountnumber)
                {
                    Console.WriteLine("Current Amount of Customer " + customer.Balance);
                    customer.Balance += amount;
                    Console.WriteLine("Amount after Adding Deposit: " + customer.Balance);
                }
            }
        }
        public void Withdraw(int accountnumber, double amount)
        {
            foreach (Customer customer in customers)
            {
                if (customer.Accountnumber == accountnumber && amount <= customer.Balance)
                {
                    Console.WriteLine("Current Amount of Customer " + customer.Balance);
                    customer.Balance -= amount;
                    Console.WriteLine("Account balance after Withdraw: " + customer.Balance);
                }
            }
        }
        public void RemoveAccount(int accountnumber)
        {
            Customer CustomertoRemove = null;
            foreach (Customer customer in customers)
            {
                if (customer.Accountnumber == accountnumber)
                {

                    CustomertoRemove=customer;              
                    break;
                }
            }
            if (CustomertoRemove != null)
            {
                customers.Remove(CustomertoRemove);
                Console.WriteLine("Account removed successfully.");
            }
            else
            { Console.WriteLine("Account not found."); }
        }
        
        public void ShowBalance(int accountnumber)
        {
            foreach (Customer customer in customers)
            {
                if (customer.Accountnumber == accountnumber)
                {
                    Console.WriteLine(customer.Name);
                    Console.WriteLine(customer.Balance);
                }
            }
        }
        public void Totalmoneyinbank()
        {
            double totalmoney = 0;
            foreach (Customer customer in customers)
            {
                totalmoney += customer.Balance;
                
            }
            Console.WriteLine("Money in Bank: " + totalmoney);

        }
        public void LowestBalance()
        {
            Customer lowestcustomer = customers[0];
           
            foreach (Customer customer in customers)
            {
                if (customer.Balance < lowestcustomer.Balance)
                {
                    lowestcustomer = customer;

                }
            }

            Console.WriteLine("Customer Name: " + lowestcustomer.Name);
            Console.WriteLine("Lowest Balance: " + lowestcustomer.Balance);
        
    }
    }
}




    