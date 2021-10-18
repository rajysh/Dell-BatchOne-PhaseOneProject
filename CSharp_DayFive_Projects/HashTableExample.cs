using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DayFive_Projects
{
    internal class ArrayExampleFive
    {
        static void MainMethod(string[] args)
        {
            //Declared an HashTable
            Hashtable hashtable= new Hashtable();
            hashtable.Add("EmpID", 1001);
            hashtable.Add("EmpName", "King Kochhar");
            hashtable.Add("EmpSalary", 12000);
            hashtable.Add("EmpDesignation", "Manager");

            //Printing Hash Keys
            foreach(var item  in hashtable.Keys)
            {
                Console.WriteLine("{0} : {1}", item, hashtable[item]);

            }


            //Print Element
            Console.WriteLine("Employee Designation: " + hashtable["EmpDesignation"]);
            Console.WriteLine("Employee Item Exists: " + hashtable.ContainsValue("King Kochhar"));
            Console.WriteLine("Employee Key Exists: " + hashtable.ContainsKey("EmpName"));

            Console.ReadKey();
        }
    }
}
