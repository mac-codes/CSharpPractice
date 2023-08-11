// 1. 10 digit number that uniquely identifies the account
// 2. string that stores Account holder's name
// 3. The balance can be retrieved
// 4. it accepts deposits
// 5. it accepts withdrawals
// 6. the initial balance must be positive
// 7. withdrawls cant result in a negative balance

// defines a class named BankAccount within the namespace Classes.
namespace Classes
{
    // The BankAccount class is a blueprint for creating bank account objects.
    public class BankAccount
    {
        // 1. A property named 'Number' to store the unique 10-digit account number.
        // It can be read (get) but cannot be directly modified from outside the class (private set).
        public string Number { get; }

        // 2. A property named 'Owner' to store the name of the account holder.
        // It can be read (get) and modified (set).
        public string Owner { get; set; }

        // 3. A property named 'Balance' to store the current balance of the account.
        // It can be read (get) but cannot be directly modified from outside the class (private set).
        public decimal Balance { get; }

        // 4. A method named 'makeDeposit' to allow depositing money into the account.
        // It takes parameters: 'amount' (the amount to deposit), 'date' (the date of the deposit),
        // and 'note' (a description of the deposit).
        public void makeDeposit(decimal amount, DateTime date, string note)
        {
            // The implementation of this method would add the 'amount' to the account balance.
        }

        // 5. A method named 'makeWithdrawal' to allow withdrawing money from the account.
        // It takes parameters: 'amount' (the amount to withdraw), 'date' (the date of the withdrawal),
        // and 'note' (a description of the withdrawal).
        public void makeWithdrawal(decimal amount, DateTime date, string note)
        {
            // The implementation of this method would subtract the 'amount' from the account balance,
            // but only if the withdrawal does not result in a negative balance.
        }
    }
}
