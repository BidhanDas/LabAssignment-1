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
        public Account(string accountName, double balance, Address address,int x)
        {  
            this.accountName = accountName;
            this.balance = balance;
            this.address = address;
            accountNumber = x;
        }
        public Account(string accountName,Address address, int x)
        {
            this.accountName = accountName;
            this.address = address;
            accountNumber = x;
        }
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
            if (balance == 0)
            {
                Console.WriteLine("Account number is: " + accountNumber + "\nAccount name is: " + accountName + "\nAccount balance is: can't be seen!!!" + "\nOwner's address is: " + address.GetAddress() + "\n");
            }
            else
                Console.WriteLine("Account number is: " + accountNumber + "\nAccount name is: " + accountName + "\nAccount balance is: " + balance + "\nOwner's address is: " + address.GetAddress() + "\n");
            
        }
    }
    class Bank
    {
        string bankName;
        Account[] myBank;

        public Bank()
        {
            bankName = ">>>Dhaka Bank Limited<<<\n";
        }
        public void AddAccount(Account account)
        {
            
        }
        
        public void DeleteAccount(int accountNumber)
        {
           
        }

        public void Transaction(int transactionType,Account ac1,double y,Account ac2 )
        {
            switch (transactionType)
            {
                case 1:
                    ac1.Deposit(y);
                    Console.WriteLine("\n>>After deposit my account");
                    ac1.ShowAccountInformation();
                    break;
                case 2:
                    ac1.Withdraw(y);
                    Console.WriteLine("\n>>After withdraw my account");
                    ac1.ShowAccountInformation();
                    break;
                default:
                    ac1.Transfer(y,ac2);
                    Console.WriteLine("\n>>After transfer my account");
                    ac1.ShowAccountInformation();
                    Console.WriteLine("\n>>Receiver's account");
                    ac2.ShowAccountInformation();
                    break;
                   
            }
        }
        public void PrintAccountDetails()
        {
            Console.WriteLine(bankName);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Bank b1 = new Bank();
            b1.PrintAccountDetails();

            Console.WriteLine(">>>My Account");
            Address a1 = new Address("10","20","Dhaka","Bangladesh");
            Account ac1 = new Account("Account_1",1000.0,a1,random.Next(1000, 2000));
            ac1.ShowAccountInformation();

            Console.WriteLine(">>>Receiver's Account");
            Address a2 = new Address("11", "22", "Comilla", "Bangladesh");
            Account ac2 = new Account("Account_2",a2, random.Next(1000, 2000));
            ac2.ShowAccountInformation();

            Console.WriteLine("What kind of transaction would you like to do?");
            Console.WriteLine("Choose one (1-3):");
            Console.WriteLine("1) Diposit");
            Console.WriteLine("2) Withdraw");
            Console.WriteLine("3) Transfer");
            
            int x = int.Parse(Console.ReadLine());

            double y;

            if (x == 1)
            {
                Console.WriteLine("Enter amount:");
                y = int.Parse(Console.ReadLine());
            }
            else if (x == 2)
            {
                Console.WriteLine("Enter amount:");
                y = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Enter amount:");
                y = int.Parse(Console.ReadLine());
            }

            b1.Transaction(x,ac1,y,ac2);



        }
    }
}
