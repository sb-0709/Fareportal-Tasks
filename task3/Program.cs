using System.Data.Common;
using bankProject.Models;

namespace task2{
    public class BankRepository:IBankRepository{
        // int transid = 0;
        List<SBAccount> sba = new List<SBAccount>();
        List<SBTransaction> sbt = new List<SBTransaction>();
        private static Ace52024Context db = new Ace52024Context();
        public void NewAccount(SanskritiSbaccount s){
            db.SanskritiSbaccounts.Add(s);
            db.SaveChanges();
        }
        public List<SanskritiSbaccount> GetAllAccounts(){
            var accs = (from i in db.SanskritiSbaccounts
                        select i).ToList();
            return accs;
        }
        public SanskritiSbaccount GetAccountDetails(int accno){
            var acc = (from i in db.SanskritiSbaccounts
                        where i.Accno == accno
                        select i).SingleOrDefault();
            return acc;
        }
        public void DepositAmount(int accno, decimal amt){
            try{
                SanskritiSbaccount s = db.SanskritiSbaccounts.Find(accno);
                if(s==null){
                    throw new AccountNotFoundException("No account found!");
                }
                else{
                s.CurrBalance = s.CurrBalance+amt;
                db.SanskritiSbaccounts.Update(s);
                db.SaveChanges();
                Random rnd = new Random();
                int transid = rnd.Next();
                SanskritiSbtransaction t = new SanskritiSbtransaction();
                t.Accno = accno;
                t.Transdate = DateTime.Now;
                t.Transid = transid;
                t.Amt = amt;
                t.Transtype = "Deposit";
                db.SanskritiSbtransactions.Add(t);
                db.SaveChanges();
                System.Console.WriteLine("Amount deposited successfully!!");
                return;
                }
            }
            catch(Exception e){
                System.Console.WriteLine(e.Message);
            }
        }
        public void WithdrawAmount(int accno, decimal amt){
            try{
                SanskritiSbaccount s = db.SanskritiSbaccounts.Find(accno);
                if(s==null){
                    throw new AccountNotFoundException("No account found!");
                }
                if(amt>s.CurrBalance){
                    throw new BalanceNotSufficientException("Account balance is not sufficient!");
                }
                else{
                    s.CurrBalance -= amt;
                    db.SanskritiSbaccounts.Update(s);
                    db.SaveChanges();
                    Random rnd = new Random();
                    int transid = rnd.Next();
                    SanskritiSbtransaction t = new SanskritiSbtransaction();
                    t.Accno = accno;
                    t.Transdate = DateTime.Now;
                    t.Transid = transid;
                    t.Amt = amt;
                    t.Transtype = "Withdraw";
                    db.SanskritiSbtransactions.Add(t);
                    db.SaveChanges();
                    System.Console.WriteLine("Amount withdrawn successfully!!");
                    return;
                }
            }
            catch(Exception e){
                System.Console.WriteLine(e.Message);
            }
        }
        public List<SanskritiSbtransaction> GetTransactions(int accno){
            var trans = (from i in db.SanskritiSbtransactions
                        where i.Accno == accno
                        select i).ToList();
            return trans;
        }
    }
}
