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

        public static int employeeHours(){
            int emplyeecheck  = checkEmployee();
            int employeeHour = 0;

            switch (emplyeecheck){
                case 1:
                    employeeHour = 8;
                    break;
                case 2:
                    employeeHour =4;
                    break;
                default :
                    employeeHour =0;
                    break;
            }
            return employeeHour;
        }

        public static int dailywage(){
            int dailywage = 0;
            int emphour = employeeHours();

            dailywage = wagePerHour * emphour;

            return dailywage;        
         }

        public static void Monthlywage(){
            int totalworkingday =20;
            int Totalwage =0 ;

            for (int i = 0; i <= totalworkingday; i++){
                int wage = dailywage();
                Console.WriteLine("Employee Wage is " + wage);
                Totalwage +=wage;
            }
            Console.WriteLine("Totalwage is " + Totalwage);

        }
    }
}