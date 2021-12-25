
namespace OOP_Homework
{
    internal class ImprovedAccount
    {
        //TODO: Use GUID or something
        private static ulong id = 0;
        private ulong _accountNumber;
        private decimal _balance;
        private AccountType _accountType;

        public decimal Balance
        {
            get => _balance;
            private set
            {
                if (value < 0 || value == _balance)
                    return;

                _balance = value;
            }
        }

        public AccountType AccountType
        {
            get => _accountType;
            private set => _accountType = value;
        }

        public ulong Id
        {
            get => _accountNumber;
            private set => _accountNumber = value;
        }

        public ImprovedAccount() : this(0, AccountType.Individual)
        { }
        
        public ImprovedAccount(decimal cash) : this(cash, AccountType.Individual)
        { }
        
        public ImprovedAccount(AccountType accountType) : this(0, accountType)
        { }
        
        public ImprovedAccount(decimal cash, AccountType accountType)
        {
            Id = id;
            IncreaseAccountNumber();
            Balance = cash;
            AccountType = accountType;
        }

        private void IncreaseAccountNumber()
        {
            id++;
        }

        public void AddCash(decimal cashToAdd)
        {
            if (cashToAdd <= 0) 
                return;   
            
            _balance += cashToAdd;
        }

        public void TransferCash(ImprovedAccount source, decimal amount)
        {
            if (source.Balance < amount)
                return;

            source.Balance -= amount;
            this.Balance += amount;
        }

        public void RemoveCash(decimal cashToRemove)
        {
            if (cashToRemove <= 0)
                return;
            
            _balance -= cashToRemove;
        }
        
        public string GetData()
        {
            return $"Account: {Id}, Balance: {Balance}, Account Type: {AccountType}";
        }
    }
}