using System;

namespace CSharp_DaySix_Misc_Projects
{
    internal class OutVariableExample
    {

        // *********************************************************************************************//

        ////Demo: Without the out parameter

        //static void GetEmployeeDetails(out string EmpName, out string Gender, out string Department, out long Salary)
        //{
        //    EmpName = "Karthik";
        //    Gender = "Male";
        //    Department = "Admin";
        //    Salary = 20000;
        //}
        //static void Main(string[] args)
        //{
        //    string EmpName, Gender, Department;
        //    long Salary;

        //    GetEmployeeDetails(out EmpName, out Gender, out Department, out Salary);
        //    Console.WriteLine("Employee Details:");

        //    Console.WriteLine("{0} : {1} : {2} : {3}", EmpName, Gender, Department, Salary);
        //    Console.ReadKey();
        //}


        // *********************************************************************************************//

        ////Demo:  With the out variable
        //static void GetEmployeeDetails(out string EmpName, out string Gender, out string Department, out long Salary)
        //{
        //    EmpName = "Karthik";
        //    Gender = "Male";
        //    Department = "Admin";
        //    Salary = 20000;
        //}
        //static void Main(string[] args)
        //{            
        //    GetEmployeeDetails(out var EmpName, out var Gender, out var Department, out var Salary);
        //    Console.WriteLine("Employee Details:");

        //    Console.WriteLine("{0} : {1} : {2} : {3}", EmpName, Gender, Department, Salary);
        //    Console.ReadKey();
        //}

        // *********************************************************************************************//

        //Demo: Ignore the out variable
        static void GetEmployeeDetails(out string EmpName, out string Gender, out string Department, out long Salary)
        {
            EmpName = "Karthik";
            Gender = "Male";
            Department = "Admin";
            Salary = 20000;
        }
        static void MainMethod(string[] args)
        {
            //string EmpName, Gender, Department;
            //long Salary;

            //GetEmployeeDetails(out EmpName, out Gender, out Department, out Salary);
            GetEmployeeDetails(out var EmpName, out var Gender, out var Department, out _);
            Console.WriteLine("Employee Details:");

            Console.WriteLine("{0} : {1} : {2}", EmpName, Gender, Department);
            Console.ReadKey();
        }
    }
}




