namespace employee_payroll_oops
{
    public class Employee
    {

        public static int wagePerHour = 20;
        public  static int FulldayHour = 8;
        public static int  checkEmployee(){
            Random random = new Random();
            int employeecheck = random.Next(0,2);
            return employeecheck;
        }

        public static void dailywage(){
            int emplyeecheck = checkEmployee();
            if(emplyeecheck == 1){
                int dailywage = wagePerHour * FulldayHour ;
                Console.WriteLine("Dailywage of Employee: " + dailywage);
            }

           
         }

    }
}