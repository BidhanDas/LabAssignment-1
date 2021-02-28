using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment_1
{
    class Address
    {
        string roadNo;
        string houseNo;
        string city;
        string country;

        public Address()
        {

        }
        public Address(string roadNo, string houseNo, string city, string country)
        {
            this.roadNo = roadNo;
            this.houseNo = houseNo;
            this.city = city;
            this.country = country;
        }

        public string GetAddress()
        {
            string x = "Road No. " + roadNo + ", House No. " + houseNo + ", City: " + city + ", Country: " + country;
            return x;
        }

    }

    class Account
    {
        int accountNumber;
        string accountName;
        double balance;
        Address address;
        
        public Account() { }
        public Account(string accountName, double balance, Address address)
        {
            Random random = new Random();
            this.accountName = accountName;
            this.balance = balance;
            this.address = address;
            accountNumber = random.Next(101,200);
        }
       /* public Account(int accountNumber, string accountName, double balance, Address address)
        {
            this.accountNumber = accountNumber;
            this.accountName = accountName;
            this.balance = balance;
            this.address = address;            
        }*/
        public void Withdraw(double amount)
        {
            balance = balance - amount;
        }
        public void Deposit(double amount)
        {
            balance = balance + amount;
        }
        public void Transfer(double amount, Account receiver)
        {
            balance = balance - amount;
        }
        public void ShowAccountInformation()
        {
            Console.WriteLine("Account number is: " + accountNumber + "\nAccount name is: "+ accountName+"\nAccount balance is: "+ balance+"\nOwner's address is: " + address.GetAddress()+"\n");
        }
    }
    /*class Bank
    {
        string bankName;
        Account[] myBank;
        /*public void AddAccount(Account account)
        {
            for(int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    myBank[i] = account;
                    break;
                }
            }
        }
        public void DeleteAccount(int accountNumber)
        {
            foreach(Account ac in myBank)
            {
                if (accountNumber == ac.accountNumber)
                {

                }
            }
        }*/

        /*public void Transaction(int transactionType,Account ac)
        {
            switch (transactionType)
            {
                case 1:

                case 2:
                default:
            }
        }
        public void PrintAccountDetails()
        {

        }
    }*/
    class Program
    {
        static void Main(string[] args)
        {
            
            Address a1 = new Address("10","20","Dhaka","Bangladesh");
            Account ac1 = new Account("Account_1",1000.0,a1);
            ac1.ShowAccountInformation();


        }
    }
}
