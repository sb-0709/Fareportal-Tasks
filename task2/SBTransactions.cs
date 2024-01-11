namespace task2{
    public class SBTransaction{
        public int Transid{
            get; set;
        }
        public DateTime Transdate{
            get; set;
        }
        public int Accno{
            get; set;
        }
        public decimal Amount{
            get; set;
        }
        public string Transtype{
            get; set;
        }

        public SBTransaction(int transid, DateTime transdate, int accno, decimal amount, string transtype){
            Transid = transid;
            Transdate = transdate;
            Accno = accno;
            Amount = amount;
            Transtype = transtype;
        }
        public override string ToString()
        {
            return "Transaction ID: "+Transid+ "\nTransaction Date: "+Transdate+"\nAccount No.: "+Accno+"\nAmount: "+Amount+"\nTransaction Type: "+ Transtype;
        }
    }
}