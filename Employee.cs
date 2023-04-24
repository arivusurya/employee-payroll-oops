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

        public static int dailywage(int emphour){
            int dailywage = 0;
            

            dailywage = wagePerHour * emphour;

            return dailywage;        
         }

       

        public static void MonthlywageConsdition(){
            int day = 0;
            int totalworkingday =20;
            int hour =0 ;
            int MaxHour =100;
            int Totalwage = 0;

            while(day < totalworkingday && hour < MaxHour){
                day++;

                int workingHour = employeeHours();
                hour = hour + workingHour; 
                int wage = dailywage(workingHour);
                Console.WriteLine($"Employee Wage on {day} : {wage}");
                Totalwage = Totalwage + wage;
            }
            Console.WriteLine($"Total working Hour : {hour}");
            Console.WriteLine($"Total Employee wage  : {Totalwage}");


        }
    }
}