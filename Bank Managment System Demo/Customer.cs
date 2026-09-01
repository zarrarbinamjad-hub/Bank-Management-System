using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_Managment_System_Demo
{
    public class Customer
    {
        public string Name {  get; set; }
        public int Accountnumber {  get; set; }
        public double Balance {  get; set; }

        public Customer(string name,int accountnumber,double  balance)
        {
            Name = name;
            Accountnumber = accountnumber;
            Balance = balance;
        }
        public void Displayinfo()
        {
            Console.WriteLine("Customer Name: " + Name);
            Console.WriteLine("Customer Accountnumber: " + Accountnumber);
            Console.WriteLine("Customer Balance: " + Balance);

        }

    }
}
