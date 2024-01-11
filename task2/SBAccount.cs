namespace task2{
    public class SBAccount{
        public int Accno{
            get; set;
        }
        public string Cname{
            get; set;
        }
        public string Curr_address{
            get; set;
        }
        public decimal Curr_balance{
            get; set;
        }
        public SBAccount(int accno, string cname, string curr_address, decimal curr_balance){
            Accno = accno;
            Cname = cname;
            Curr_address = curr_address;
            Curr_balance = curr_balance;
        }

        public override string ToString()
        {
            return "Account No.: "+Accno+"\nCustomer Name: "+Cname+"\nCurrent Address: "+Curr_address+"\nCurrent Balance: "+Curr_balance;
        }
    }
}