using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4_assignment
{
    internal class BankAccount
    {
        private string _accountNumber;
        private decimal _balance;

        public BankAccount(string accountNumber )
        {
            this._balance= 0;
            this._accountNumber = accountNumber;
        }

        

        public void Deposit(decimal amount)
        {
            _balance+= amount;
            
        }

        public void Withdraw(decimal amount)
        {
            _balance -= amount;
                    
        }

        public decimal GetBalance()
        {
            return _balance;
        }
    }


}
