
namespace OOP_Homework
{
    internal class ImprovedAccount
    {
        //TODO: Use GUID or something
        private static long id = 0;
        private static long _accountNumber;
        private decimal _balance;
        private AccountType _accountType;
        
        public ImprovedAccount() : this(0, AccountType.Individual)
        { }
        
        public ImprovedAccount(decimal cash) : this(cash, AccountType.Individual)
        { }
        
        public ImprovedAccount(AccountType accountType) : this(0, accountType)
        { }
        
        public ImprovedAccount(decimal cash, AccountType accountType)
        {
            _accountNumber = id;
            IncreaseAccountNumber();
            _balance = cash;
            _accountType = accountType;
        }

        private void IncreaseAccountNumber()
        {
            id++;
        }

        //TODO: still need something like addCash / removeCash
        public string GetData()
        {
            return $"Account: {_accountNumber}, Balance: {_balance}, Account Type: {_accountType}";
        }
    }
}