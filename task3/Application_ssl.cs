using System.Security.AccessControl;
using bankProject.Models;

namespace task2{
    class app{
        // private static Ace52024Context db = new Ace52024Context();
        public static void Main(){
            IBankRepository br = new BankRepository();
            while(true){
                System.Console.WriteLine("\n.....Choose an option......\n");
                System.Console.WriteLine("1. Create a new account");
                System.Console.WriteLine("2. Get all accounts");
                System.Console.WriteLine("3. Get account details");
                System.Console.WriteLine("4. Deposit amount");
                System.Console.WriteLine("5. Withdraw amount");
                System.Console.WriteLine("6. Get all your transactions");
                System.Console.WriteLine("7. Exit");
                System.Console.WriteLine("\nEnter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch(choice){
                    case(1):
                    {
                        SanskritiSbaccount s = new SanskritiSbaccount();
                        System.Console.WriteLine("\nEnter account number");
                        s.Accno = Convert.ToInt32(Console.ReadLine());
                        System.Console.WriteLine("Enter your name");
                        s.Cname = Console.ReadLine();
                        System.Console.WriteLine("Enter your current address");
                        s.CurrAddress = Console.ReadLine();
                        System.Console.WriteLine("Enter your current balance");
                        s.CurrBalance = Convert.ToDecimal(Console.ReadLine());
                        br.NewAccount(s);
                        // SBAccount sba = new SBAccount(accno, cname, curraddr, currbal);
                        // br.NewAccount(sba);
                        // System.Console.WriteLine(sba);
                        break;
                    }
                    case(2):
                    {
                        List<SanskritiSbaccount> accs = br.GetAllAccounts();
                        try{
                            if(accs.Count==0){
                                throw new AccountNotFoundException("\nNo account in records!");
                            }
                            System.Console.WriteLine("\nAll account details are:");
                            foreach(var item in accs)
                            {
                                System.Console.WriteLine("\nAccount no.:"+ item.Accno);
                                System.Console.WriteLine("Customer name:"+ item.Cname);
                                System.Console.WriteLine("Current address:"+ item.CurrAddress);
                                System.Console.WriteLine("Current balance:"+ item.CurrBalance);
                            }
                            break;
                        }
                        catch(Exception e){
                            System.Console.WriteLine(e.Message);
                        }
                        break;
                    }
                    case(3):
                    {
                        System.Console.WriteLine("\nEnter the account number: ");
                        int accno = Convert.ToInt32(Console.ReadLine());
                        SanskritiSbaccount item = br.GetAccountDetails(accno);
                        try{
                            if(item==null){
                                throw new AccountNotFoundException("\nNo account found!");
                            }
                            System.Console.WriteLine("\nAccount no.:"+ item.Accno);
                            System.Console.WriteLine("Customer name:"+ item.Cname);
                            System.Console.WriteLine("Current address:"+ item.CurrAddress);
                            System.Console.WriteLine("Current balance:"+ item.CurrBalance);
                        }
                        catch(Exception e){
                            System.Console.WriteLine(e.Message);
                        }
                        break;
                    }
                    case(4):
                    {
                        System.Console.WriteLine("\nEnter the account number: ");
                        int accno = Convert.ToInt32(Console.ReadLine());
                        System.Console.WriteLine("\nEnter the amount to be deposited: ");
                        decimal amt = Convert.ToDecimal(Console.ReadLine());
                        br.DepositAmount(accno, amt);
                        break;
                    }
                    case(5):
                    {
                        System.Console.WriteLine("\nEnter the account number: ");
                        int accno = Convert.ToInt32(Console.ReadLine());
                        System.Console.WriteLine("\nEnter the amount to be withdrawn: ");
                        decimal amt = Convert.ToDecimal(Console.ReadLine());
                        br.WithdrawAmount(accno, amt);
                        break;                        
                    }
                    case(6):
                    {
                        System.Console.WriteLine("\nEnter the account number: ");
                        int accno = Convert.ToInt32(Console.ReadLine());
                        try{
                        List<SanskritiSbtransaction> sbt = br.GetTransactions(accno);
                        if(sbt.Count==0){
                            throw new NoTransactionFoundException("No transactions are found!");
                        }
                        System.Console.WriteLine("All the transactions for account number "+accno+" are:");
                        foreach(var item in sbt)
                        {
                            System.Console.WriteLine("\nAccount no.:"+ item.Accno);
                            System.Console.WriteLine("Transaction ID:"+ item.Transid);
                            System.Console.WriteLine("Transaction date:"+ item.Transdate);
                            System.Console.WriteLine("Amount:"+ item.Amt);
                            System.Console.WriteLine("Transaction type:"+ item.Transtype);
                        }
                        }
                        catch(Exception e){
                            System.Console.WriteLine(e.Message);
                        }
                        break;                        
                    }
                    case(7):
                    {
                        Environment.Exit(0);
                        break;
                    }
                    default:
                        System.Console.WriteLine("\nEnter valid choice!");;
                        break;
                }
            }
        }
    }
}
