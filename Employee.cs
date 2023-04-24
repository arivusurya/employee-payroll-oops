namespace employee_payroll_oops
{
    public class Employee
    {
        public static void checkEmployee(){
            Random random = new Random();
            int employeecheck = random.Next(0,2);
            if(employeecheck == 0){
                Console.WriteLine("Employee is Absent");
            }else{
                Console.WriteLine("Employee is present");
            }
        }
    }
}