namespace task1{
    class IPermenant:IEmployee{
        public int Empid{get; set;}
        public string? Empname{get; set;}
        public DateTime Doj{get; set;}
        public int Basicpay{get; set;}
        public int Hra{get; set;}
        public int Da{get; set;}
        public int Pf{get; set;}
        public float Salary{get; set;}
        public void AcceptDetails(){
            // base.AcceptDetails();
            Console.WriteLine("Enter Employee ID: ");
            Empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name: ");
            Empname = Console.ReadLine();
            Console.WriteLine("Enter Date of Joining: ");
            Doj = Convert.ToDateTime(Console.ReadLine());
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
            Console.WriteLine("Employee name: "+Empname);
            Console.WriteLine("Employee ID: "+ Empid);
            Console.WriteLine("Date of Joining: "+ Doj);
            Console.WriteLine("Calculated Salary for Permenant Employee is: "+ Salary);
        }
        public void CalculateSalary(){
            Salary = Basicpay + Hra + Da - Pf;
        }
    }

    class ITrainee:IEmployee{
        public int Empid{get; set;}
        public string? Empname{get; set;}
        public DateTime Doj{get; set;}
        public int Saltrainee{get; set;}
        public String Projname{get; set;}
        public float Salary{get; set;}

        public void AcceptDetails(){
            // base.AcceptDetails();
            Console.WriteLine("Enter Employee ID: ");
            Empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name: ");
            Empname = Console.ReadLine();
            Console.WriteLine("Enter Date of Joining: ");
            Doj = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter Salary: ");
            Saltrainee = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Project Name (Banking/Insurance): ");
            Projname = Console.ReadLine();
        }
        public void DisplayDetails(){
            // base.DisplayDetails();
            Console.WriteLine("Employee name: "+Empname);
            Console.WriteLine("Employee ID: "+ Empid);
            Console.WriteLine("Date of Joining: "+ Doj);
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
            else{
                Salary = 0;
            }
        }
    }
}