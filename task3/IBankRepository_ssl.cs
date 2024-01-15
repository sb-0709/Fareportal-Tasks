using bankProject.Models;

namespace task2{
    public interface IBankRepository{
        void NewAccount(SanskritiSbaccount s);
        List<SanskritiSbaccount> GetAllAccounts();
        SanskritiSbaccount GetAccountDetails(int accno);
        void DepositAmount(int accno, decimal amt);
        void WithdrawAmount(int accno, decimal amt);
        List<SanskritiSbtransaction> GetTransactions(int accno);
    }
}