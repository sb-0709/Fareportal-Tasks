namespace task2{
    public class BalanceNotSufficientException:ApplicationException{
        public BalanceNotSufficientException(string message):base(message){}
    }
    public class AccountNotFoundException:ApplicationException{
        public AccountNotFoundException(string message):base(message){}
    }
    public class NoTransactionFoundException:ApplicationException{
        public NoTransactionFoundException(string message):base(message){}
    }
}