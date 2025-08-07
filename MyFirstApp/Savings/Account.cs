    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace MyFirstApp.Savings;

    internal class Account
    {
        private long _accountNumber;
        private string _name;
        private string _address;
        private long _contactNumber;
        private string _parentage;
        private decimal _balance;
    
        //static fields ----------------

        private static int _bankAccounts;
        private static decimal _totalBankFunds;

        //get set props ---------------------------------------------

        public long AccountNumber {  
            get { 
                return _accountNumber; 
            } 
            set { 
                    if (value > 0 && value.ToString().Length == 12)
                    _accountNumber = value;
                    else
                    Console.WriteLine("Enter a valid account number");
                }
        }

        public string Name
        {
            get { 
                return _name; 
            }
            set {
                if (!string.IsNullOrEmpty(value))
                    _name = value;
                else
                    Console.WriteLine("Enter Valid Name");
            }

        }

        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _address = value;
                else
                    Console.WriteLine("Enter valid address");
            }
        }

        public long ContactNumber
        {
            get
            {
                return _contactNumber;
            }
            set { 
                if(value > 0 && value.ToString().Length == 10)
                    _contactNumber = value;
            }
        }

        public string Email { get; set; } = "enter your email address";

        public string Parentage
        {
            get
            {
                return _parentage;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _parentage = value;
                else
                    Console.WriteLine("Enter your Father's/Guardians name");
            }
        }

        public decimal Balance { get; private set; } = 1000.00m;

        public static int BankAccounts
        {
            get { 
                return _bankAccounts; 
            }
            set { 
                _bankAccounts = value; 
            }
        }

        public static decimal TotalBankFunds
        {
            get { 
                return _totalBankFunds; 
            }
            set { 
                _totalBankFunds = value; 
            }
        }

        //constructors ----------------------------------------------------

        public Account()
        {
            _accountNumber = 0;
            _name = "Unknown";
            _address = "Not Set";
            _contactNumber = 0;
            Email = "enter your email address";
            _parentage = "Unknown";
            _balance = 1000.00m;

            _bankAccounts++;
            _totalBankFunds += _balance;
        }

        public Account(long accountNumber, string name, string address, long contactNumber, string email, string parentage, decimal balance)
        {
            AccountNumber = accountNumber;   
            Name = name;                     
            Address = address;               
            ContactNumber = contactNumber;   
            Email = email;                   
            Parentage = parentage;           

            if (balance >= 1000.00m)
            {
                _balance = balance;     
            }
            else
            {
                Console.WriteLine("Minimum balance must be ₹1000. Setting default.");
                _balance = 1000.00m;
            }

            _bankAccounts++;
            _totalBankFunds += _balance;
        }


        public Account( Account copyAccount)
        {
            AccountNumber = copyAccount.AccountNumber;
            Name = copyAccount.Name;
            Address = copyAccount.Address;
            ContactNumber = copyAccount.ContactNumber;
            Email = copyAccount.Email;
            Parentage = copyAccount.Parentage;
            _balance = copyAccount.Balance;

            _bankAccounts++;
            _totalBankFunds += _balance;
        }

        static Account()
        {
            _bankAccounts=0;
            _totalBankFunds=0;
         }



        //Methods ---------------------------------------------

        public void AddBalance(decimal amount)
        {
            if (amount > 0)
            {
                _balance += amount;      
                _totalBankFunds += amount;
            }
        }

        public void Withdrawal(decimal amount)
        {
            if (amount >0 && amount <= Balance)
            {
                _balance -= amount;
                _totalBankFunds -= amount;
                Console.WriteLine($@"Transaction Successful
    Withdraw Amount is: {amount},
    Remaining Balance is: {Balance}");
            }
            else
                Console.WriteLine("Insufficient Balance");
        }

         public void DisplayAccountDetails()
        {
        Console.WriteLine($@"Your Account Details Are:
Account Number:{AccountNumber}
Name:{Name}
Address:{Address}
Contact Number:{ContactNumber}
Parentage:{Parentage}
Email:{Email}
Account Balance:{Balance}
");
        }
    }