using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_account
{
    //savings account class inherited from bank account class
    public class savingsAccount :BankAccount
    {
        public Decimal interestRate { get; set; }

        public savingsAccount(string Owner, Decimal interestRate) : base(Owner + "("+ interestRate+"%)")
        {
            this.interestRate = interestRate;
        }

        public override string Deposite(Decimal amount)
        {
            if (amount <= 0)
                return "cant Deposite $" + amount;
            if (amount > 200000)
                return "AML Deposite limit reached";

            decimal interestAmount = (amount * interestRate) / 100;
            Balance += amount + interestAmount ;
            return "Deposite successfully";

        }
    }
}
