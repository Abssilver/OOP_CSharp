namespace OOP_Homework
{
    internal class Account
    {
        private long _accountNumber;
        private decimal _balance;
        private AccountType _accountType;

        public decimal GetBalance() => _balance;
        public AccountType GetAccountType() => _accountType;

        public void AssignId(long id)
        {
            _accountNumber = id;
        }

        public void AddCash(decimal cashToAdd)
        {
            _balance += cashToAdd;
        }

        public void RemoveCash(decimal cashToRemove)
        {
            _balance -= cashToRemove;
        }

        public void ChangeAccountType(AccountType typeToChange)
        {
            _accountType = typeToChange;
        }

        public string GetData()
        {
            return $"Account: {_accountNumber}, Balance: {_balance}, Account Type: {_accountType}";
        }
    }
    public enum AccountType
    {
        Individual,
        Legal,
    }
}