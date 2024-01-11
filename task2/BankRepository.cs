namespace task2{
    public class BankRepository:IBankRepository{
        int transid = 0;
        List<SBAccount> sba = new List<SBAccount>();
        List<SBTransaction> sbt = new List<SBTransaction>();
        public void NewAccount(SBAccount acc){
            sba.Add(acc);
        }
        public List<SBAccount> GetAllAccounts(){
            return sba;
        }
        public SBAccount? GetAccountDetails(int accno){
            foreach(SBAccount item in sba){
                if(item.Accno==accno){
                    return item;
                }
            }
            return null;
        }
        public void DepositAmount(int accno, decimal amt){
            foreach(var item in sba){
                if(item.Accno==accno){
                    item.Curr_balance = item.Curr_balance + amt;
                    transid++;
                    SBTransaction trans = new SBTransaction(transid, DateTime.Now, accno, amt, "Deposit");
                    sbt.Add(trans);
                    System.Console.WriteLine("Amount deposited successfully!!");
                    break;
                }
            }
        }
        public void WithdrawAmount(int accno, decimal amt){
            foreach(var item in sba){
                if(item.Accno==accno){
                    item.Curr_balance = item.Curr_balance - amt;
                    transid++;
                    SBTransaction trans = new SBTransaction(transid, DateTime.Now, accno, amt, "Withdraw");
                    sbt.Add(trans);
                    System.Console.WriteLine("Amount withdrawn successfully!!");
                    break;
                }
            }
        }
        public List<SBTransaction> GetTransactions(int accno){
            return sbt.FindAll(tx=>tx.Accno==accno);
        }
    }
}