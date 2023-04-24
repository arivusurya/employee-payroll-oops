namespace employee_payroll_oops
{
    public class Employee
    {

        public static int wagePerHour = 20;
        public  static int FulldayHour = 8;

        public static int ParttimeHour = 4;

        public static int  checkEmployee(){
            Random random = new Random();
            int employeecheck = random.Next(0,3);
            return employeecheck;
        }

        public static void dailywage(){
            int dailywage = 0;
            int emplyeecheck = checkEmployee();
            if(emplyeecheck == 1){
                 dailywage = wagePerHour * FulldayHour ;
                Console.WriteLine("Dailywage of Employee: " + dailywage);
            }else if(emplyeecheck == 2){
                 dailywage = wagePerHour * ParttimeHour ;
                Console.WriteLine("Dailywage of Employee: " + dailywage);
            }else{
                Console.WriteLine("Dailywage of Employee: " + dailywage);
            }           
         }

    }
}