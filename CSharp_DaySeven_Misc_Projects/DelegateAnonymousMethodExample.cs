using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DaySeven_Misc_Projects
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Experience { get; set; }
        public double Salary { get; set; }

        internal static bool GetEmployee(Employee obj)
        {
            return obj.Id == 101;
        }
    }

        internal class DelegateAnonymousMethodExample
    {


        public delegate string GreetingDelegate(string name);
        public static void Main(string[] args)
        {
            //GreetingDelegate greeting = delegate (string name)
            //{
            //    return $"Hello {name}";
            //};
            //string result = greeting.Invoke("Bhawna Gunwani");
            //Console.WriteLine(result);

            //OR

            GreetingDelegate greetingDelegate = (name) => { return $"Hello {name}!!";};            
            string result = greetingDelegate.Invoke("Bhawna Gunwani");
            Console.WriteLine(result);

            //---------------------------------------------------------------------------------
            Predicate<Employee> employeePredicate = new Predicate<Employee>(Employee.GetEmployee);

            Employee emp1 = new Employee() { Id = 101, Name = "King", Gender = "Male", Experience = 5, Salary = 10000 };
            Employee emp2 = new Employee() { Id = 102, Name = "Sarah", Gender = "Male", Experience = 5, Salary = 20000 };
            Employee emp3 = new Employee() { Id = 103, Name = "Kochar", Gender = "Male", Experience = 5, Salary = 30000 };
            List<Employee> employeeList = new List<Employee>();

            employeeList.Add(emp1);
            employeeList.Add(emp2);
            employeeList.Add(emp3);

            Employee emp = employeeList.Find(
                delegate(Employee x)
            {
                return x.Id == 101;
            });

            Console.WriteLine(emp.Id);


            Console.ReadKey();
        }
    }
}
