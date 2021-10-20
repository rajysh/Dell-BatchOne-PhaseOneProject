using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DaySix_Misc_Projects
{
    internal class TupleExample
    {
        ////static Tuple<int,double> Calculate(IEnumerable<double> list)  //Explicit Tuple
        ////static (int,double) Calculate(IEnumerable<double> list) //Inline Tuple
        //static (int count,double sum) Calculate(IEnumerable<double> list) //Inline Tuple with defining name
        //{
        //    int count = 0;
        //    double sum = 0.0d;
        //    foreach(var value in list)
        //    {
        //        count++;
        //        sum += value;
        //    }
        //    Tuple<int,double> result = Tuple.Create(count, sum);
        //    return (count, sum);
        //}
        //static void Main(string[] args)
        //{
        //    var list = new List<double>() { 10, 20, 30, 40, 50 };
        //    //Tuple<int, double> t = Calculate(list);//Explicit Tuple
        //    //var t = Calculate(list);//Inline Tuple
        //    //Console.WriteLine("There are {0} items in list : " + t.Item1);
        //    //Console.WriteLine("Sum of their values list : " + t.Item2);
        //    var (countResult, sumResult) = Calculate(list); //Inline Tuple with defining name
        //    Console.WriteLine("There are {0} items in list : " + countResult);
        //    Console.WriteLine("Sum of their values list : " + sumResult);

        //    Console.ReadKey();
        //}


        //----------------------------------Splitting Tuples-------------------------------------------

        static (string, string, string, double) GetEmployeeDetails(long EmployeeId)
        {
            //Based on the employeeid, we ll get the details
            string EmployeeName = "Kartik";
            string Gender = "Male";
            string Department = "Admin";
            double Salary = 12000;

            return(EmployeeName, Gender, Department, Salary);
        }
        static void MainMethod(string[] args)
        {
            //var empDetails = GetEmployeeDetails(1001);

            //var Name = empDetails.Item1;
            //var Gender = empDetails.Item2;
            //var Department = empDetails.Item3;
            //var Salary = empDetails.Item4;

            (string Name, string Gender, string Department, double Salary) = GetEmployeeDetails(1001);


            Console.WriteLine("Employee Details:");
            Console.WriteLine($"{Name} : {Gender} : {Department} : {Salary}");

            Console.ReadKey();
        }
    }
}
