using System;
using System.IO.Compression;
namespace task1{
    class EmpClient{
        public static void Main(){
            //for employee class derived by permenant and trainee class
            // Permenant e = new Permenant();
            // Console.WriteLine("\n....Permenant Employee.....\n");
            // e.AcceptDetails();
            // e.GetDetails();
            // e.CalculateSalary();
            // Console.WriteLine("\n....Details of Permenant Employee.....\n");
            // e.DisplayDetails();
            // e.ShowDetails();
            // Trainee e1 = new Trainee();
            // Console.WriteLine("\n\n....Trainee Employee.....\n");
            // e1.AcceptDetails();
            // e1.GetTraineeDetails();
            // e1.CalculateSalary();
            // Console.WriteLine("\n....Details of Trainee Employee.....\n");
            // e1.DisplayDetails();
            // e1.ShowTraineeDetails();

            //for IEmployee interface implemented by IPermanant and ITrainee class
            Console.WriteLine("\n....Permenant Employee.....\n");
            IEmployee e2 = new IPermenant();
            e2.AcceptDetails();
            e2.CalculateSalary();
            Console.WriteLine("\n....Details of Permenant Employee.....\n");
            e2.DisplayDetails();
            IEmployee e3 = new ITrainee();
            Console.WriteLine("\n\n....Trainee Employee.....\n");
            e3.AcceptDetails();
            e3.CalculateSalary();
            Console.WriteLine("\n....Details of Trainee Employee.....\n");
            e3.DisplayDetails();

        }
    }
}