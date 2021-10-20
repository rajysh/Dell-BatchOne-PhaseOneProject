using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DaySix_Misc_Projects
{

    partial class Employee
    {
        private string FirstName;
        private string LastName;

        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Employee(string firstName) => FirstName = firstName;

        public string Name
        {
            get => FirstName;
            set => FirstName = value;
        }
        
        public string GetFullName() => $"{FirstName} {LastName}!!";

        public override string ToString() => $"{FirstName} {LastName}!!!!";

        public void DisplayDetails() => Console.WriteLine(GetFullName());
    }
    class ExpressionBodiedExample
    {
        static void MainMethod(string[] args)
        {
            Employee employee = new Employee("Bhawna", "Gunwani");

            Console.WriteLine(employee.GetFullName());
            Console.WriteLine(employee);
            employee.DisplayDetails();

            Employee employee2 = new Employee("Bhawna");
            Console.WriteLine(employee2.Name);
            employee2.Name = "Gunwani";
            Console.WriteLine(employee2.Name);

            Console.WriteLine();
        }
    }
}
