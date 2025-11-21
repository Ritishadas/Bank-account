namespace Bank_account
{
    public partial class Form1 : Form
    {
        List<BankAccount> bankAccounts = new List<BankAccount>();  //to create the list of bank account
        public Form1()
        {
            InitializeComponent();
            //BankAccount bankAccount1 = new BankAccount("Ritisha Das");
            //bankAccount1.Owner = "Ritisha Das";
            //bankAccount1.AccountNo = Guid.NewGuid();
            //bankAccount1.Balance = 1000;

            //BankAccount bankAccount2 = new BankAccount("Sahina khan");
            //bankAccount2.Owner = "Sahina khan";
            //bankAccount2.AccountNo = Guid.NewGuid();
            //bankAccount2.Balance = 500;

            //BankAccount bankAccount3 = new BankAccount("Priti Das");
            //bankAccount3.Owner = "Priti Das";
            //bankAccount3.AccountNo = Guid.NewGuid();
            //bankAccount3.Balance = 2550;

            //List<BankAccount> bankAccounts = new List<BankAccount>();
            //bankAccounts.Add(bankAccount1);
            //bankAccounts.Add(bankAccount2);
            //bankAccounts.Add(bankAccount3);

            //backaccgrid.DataSource = bankAccounts;
        }
        private void createBTN(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Accountname.Text))  //if the textbar is empty then will not create anything
                return;
            if(InterestRateNum.Value > 0) //if the interest rate is more than 0 then create the saving account
            {
                savingsAccount savingsAccount = new savingsAccount(Accountname.Text, InterestRateNum.Value);
                bankAccounts.Add(savingsAccount);
                Refreshgrid();
                Accountname.Text = string.Empty;
                InterestRateNum.Value = 0;
                return;
            }
            else {
                //regular bank account
                BankAccount bankAccount = new BankAccount(Accountname.Text);  //create object and add the text event
                bankAccounts.Add(bankAccount);  //add in the list
                Refreshgrid(); //call the refresh function
                Accountname.Text = string.Empty;  //can remove the text from the textbar after create the account 
            }
        }  
        private void Refreshgrid()
        {
            backaccgrid.DataSource = null; //to remove the previous data
            backaccgrid.DataSource = bankAccounts;//to add the new data
        }

        private void Deposite_Click(object sender, EventArgs e)
        {
            if (backaccgrid.SelectedRows.Count == 1 && Amount.Value > 0)
            {
                BankAccount selectBankAccount = backaccgrid.SelectedRows[0].DataBoundItem as BankAccount;
                string msg = selectBankAccount.Deposite(Amount.Value);
                Refreshgrid();
                Amount.Value = 0;
                MessageBox.Show(msg);

            }
        }
        private void withdrawbtn_Click(object sender, EventArgs e)
        {
            if (backaccgrid.SelectedRows.Count == 1 && Amount.Value > 0)
            {
                BankAccount selectBankAccount = backaccgrid.SelectedRows[0].DataBoundItem as BankAccount;
                string msg = selectBankAccount.Withdraw(Amount.Value);
                Refreshgrid();
                Amount.Value = 0;
                MessageBox.Show(msg);

            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Amount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
