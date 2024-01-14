using System.Security.AccessControl;

namespace task2{
    class app{
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
                        System.Console.WriteLine("\nEnter account number");
                        int accno = Convert.ToInt32(Console.ReadLine());
                        System.Console.WriteLine("Enter your name");
                        string cname = Console.ReadLine();
                        System.Console.WriteLine("Enter your current address");
                        string curraddr = Console.ReadLine();
                        System.Console.WriteLine("Enter your current balance");
                        decimal currbal = Convert.ToDecimal(Console.ReadLine());
                        SBAccount sba = new SBAccount(accno, cname, curraddr, currbal);
                        br.NewAccount(sba);
                        // System.Console.WriteLine(sba);
                        break;
                    }
                    case(2):
                    {
                        List<SBAccount> accs = br.GetAllAccounts();
                        try{
                            if(accs.Count==0){
                                throw new AccountNotFoundException("\nNo account in records!");
                            }
                            System.Console.WriteLine("\nAll account details are:");
                            foreach(SBAccount item in accs)
                            {
                                System.Console.WriteLine(item);
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
                        SBAccount sba = br.GetAccountDetails(accno);
                        try{
                            if(sba==null){
                                throw new AccountNotFoundException("\nNo account found!");
                            }
                            System.Console.WriteLine(sba);
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
                        List<SBTransaction> sbt = br.GetTransactions(accno);
                        if(sbt.Count==0){
                            throw new NoTransactionFoundException("No transactions are found!");
                        }
                        System.Console.WriteLine("All the transactions for account number "+accno+" are:");
                        foreach(SBTransaction item in sbt)
                        {
                            System.Console.WriteLine(item);
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
