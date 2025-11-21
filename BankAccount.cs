using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_account
{
    public class BankAccount
    {
        public string Owner {  get; set; }
        public Guid AccountNo { get; set; }
        public Decimal Balance { get; protected set; }

        public BankAccount(string Owner)
        {
           this.Owner = Owner;
            AccountNo=Guid.NewGuid(); 
            Balance = 0 ;
        } 
        public virtual string Deposite(Decimal amount)
        {
            if (amount <= 0)
                return "cant Deposite $" + amount;
            if (amount > 200000)
                return "AML Deposite limit reached";
            Balance += amount;
            return "Deposite successfully";
            
        }
        public string Withdraw(Decimal amount)
        {
            if (amount <= 0)
                return "cant withdraw $" + amount;
            if (amount > Balance)
                return "Dont have enough money";
            Balance -= amount;
            return "withdraw successfully";

        }

    }
}
