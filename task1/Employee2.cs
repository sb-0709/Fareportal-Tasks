namespace task1{
    class IPermenant:IEmployee{
        public int Basicpay{get; set;}
        public int Hra{get; set;}
        public int Da{get; set;}
        public int Pf{get; set;}
        public float Salary{get; set;}
        public void AcceptDetails(){
            // base.AcceptDetails();
            Console.WriteLine("Enter Basic Pay: ");
            Basicpay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter HRA: ");
            Hra = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter DA: ");
            Da = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter PF: ");
            Pf = Convert.ToInt32(Console.ReadLine());
        }
        public void DisplayDetails(){
            // base.DisplayDetails();
            Console.WriteLine("Calculated Salary for Permenant Employee is: "+ Salary);
        }
        public void CalculateSalary(){
            Salary = Basicpay + Hra + Da - Pf;
        }
    }

    class ITrainee:IEmployee{
        public int Saltrainee{get; set;}
        public String Projname{get; set;}
        public float Salary{get; set;}

        public void AcceptDetails(){
            // base.AcceptDetails();
            Console.WriteLine("Enter Salary: ");
            Saltrainee = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Project Name (Banking/Insurance): ");
            Projname = Console.ReadLine();
        }
        public void DisplayDetails(){
            // base.DisplayDetails();
            Console.WriteLine("Project Name: "+Projname);
            Console.WriteLine("Calculated Salary for Trainee is: " + Salary);
            
        }
        public void CalculateSalary()
        {
            if(Projname=="banking"){
                Salary = float.Parse((Saltrainee + 0.05*Saltrainee).ToString());
            }
            else if(Projname=="insurance"){
                Salary = float.Parse((Saltrainee + 0.1*Saltrainee).ToString());
            }
        }
    }
}