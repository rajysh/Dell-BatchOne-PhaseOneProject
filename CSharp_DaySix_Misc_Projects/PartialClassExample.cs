using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DaySix_Misc_Projects
{
    partial class Employee //Employee Class already there in ExpressionBodiedExample.cs file, also in the same file
    {       
        public string Gender {  get; set; }
        public double Salary { get; set; }        
    }

    partial class Employee
    {
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("First Name : {0}", FirstName);
            Console.WriteLine("Last Name : {0}", LastName);
            Console.WriteLine("Salary : {0}", Salary);
            Console.WriteLine("Gender : {0}", Gender);
        }
    }


    /// <summary>
    /// Another example
    /// </summary>
    /// 

    public interface IEmployee
    {
        void EmployeeMethod();
    }

    public interface ICustomer
    {
        void CustomerMethod();
    }
    

    public partial class PartialClass : IEmployee
    {
        partial void PartialMethod();

        public void PublicMethod()
        {
            Console.WriteLine("Employee - Public Method Invoked.");
            PartialMethod();

        }
        public void EmployeeMethod()
        {
            Console.WriteLine("Employee Method Invoked.");

        }
    }

    public partial class PartialClass : ICustomer
    {
        partial void PartialMethod()
        {
            Console.WriteLine("Partial Method Invoked at Customer.");

        }
        public void CustomerMethod()
        {
            Console.WriteLine("Customer Method Invoked.");
        }
    }

    class PartialClassExample
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Rajesh", "Babu");
            employee.Gender = "Male";
            employee.Salary = 20000;

            employee.GetFullName();
            employee.DisplayDetails();
            employee.DisplayEmployeeDetails();

            Console.ReadKey();

            PartialClass partialClass = new PartialClass();
            partialClass.CustomerMethod();
            partialClass.EmployeeMethod();
            partialClass.PublicMethod();

            Console.ReadKey();
        }
    }

}
