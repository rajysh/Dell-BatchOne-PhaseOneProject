using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DaySeven_Misc_Projects
{
    public delegate bool EligibleToPromotion(EmployeeClass employeeToPromotion);

    public class EmployeeClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Experience { get; set; }
        public double Salary { get; set; }

        public static void PromoteEmployee(List<EmployeeClass> employees, EligibleToPromotion isEmployeeEligible)
        {
            foreach (EmployeeClass employee in employees)
            {
                if (isEmployeeEligible(employee))
                {
                    Console.WriteLine("Employee {0} promoted", employee.Name);
                }
            }
        }

        public static bool Promote(EmployeeClass employee)
        {
            if (employee.Salary > 10000)
                return true;
            else
                return false;
        }
    }

    
    internal class DelegateRealTimeExample
    {
      
        public static void MainMethod(string[] args)
        {
            EmployeeClass emp1 = new EmployeeClass() { Id = 101, Name = "King", Gender = "Male", Experience = 5, Salary = 10000 };
            EmployeeClass emp2 = new EmployeeClass() { Id = 102, Name = "Sarah", Gender = "Male", Experience = 5, Salary = 20000 };
            EmployeeClass emp3 = new EmployeeClass() { Id = 103, Name = "Kochar", Gender = "Male", Experience = 5, Salary = 30000 };
            List<EmployeeClass> employeeList = new List<EmployeeClass>();

            employeeList.Add(emp1);
            employeeList.Add(emp2);
            employeeList.Add(emp3);

            //EligibleToPromotion eligibleToPromotion = new EligibleToPromotion(Employee.Promote);
            //Employee.PromoteEmployee(employeeList, eligibleToPromotion);

            EmployeeClass.PromoteEmployee(employeeList, e => e.Salary > 10000);

            Console.ReadKey();
        
        }
    }
}
