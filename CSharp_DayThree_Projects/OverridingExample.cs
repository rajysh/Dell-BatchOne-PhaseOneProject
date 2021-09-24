using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DayThree_Projects
{
    class Person
    {
        private int _personId;
        private string _personName;

        public Person(int personId, string personName)
        {
            _personId = personId;
            _personName = personName;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Id: {this._personId}, Name: {this._personName}");
        }

    }

    class Employee : Person
    {
        private float _salary;
        private string _designation;

        public Employee(int personId, string personName, float salary, string designation) : base(personId, personName)
        {            
            this._salary = salary;
            this._designation = designation;
        }

        protected new void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Salary: {this._salary}, Designation: {this._designation}");
        }

    }
    class OverridingExample
    {
        static void MainMethod(string[] args)
        {
            Employee emp = new Employee(1001, "Bhawna", 10000, "Software Engineer");
            emp.DisplayDetails();

            Person person = new Employee(1001, "Bhawna", 10000, "Software Engineer");
            person.DisplayDetails();
        }
    }
}