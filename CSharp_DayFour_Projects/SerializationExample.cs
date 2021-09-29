using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DayFour_Projects
{
    [Serializable]
    class Employee
    {
        public string Name { get; set; }

        public float Salary { get; set; }

        public int Age { get; set; }
    }

    class SerializeDeserialize
    {
        public static void Serialize(Employee employee)
        {
            IFormatter formatter = new BinaryFormatter();
            using (FileStream fileStream =
                new FileStream("C:\\Users\\rajesh_b2\\OneDrive - Dell Technologies\\Work\\FSD\\Projects\\PhaseOne\\CSharp Basics\\Dell-BatchOne-PhaseOne-Project\\CSharp_DayFour_Projects\\data\\info.txt",
                FileMode.Create, FileAccess.Write))
            {
                formatter.Serialize(fileStream, employee);
                Console.WriteLine("Employee Object Serialized.");
            }
        }

        public static Employee Deserialize()
        {
            IFormatter formatter = new BinaryFormatter();
            using (FileStream fileStream =
                new FileStream("C:\\Users\\rajesh_b2\\OneDrive - Dell Technologies\\Work\\FSD\\Projects\\PhaseOne\\CSharp Basics\\Dell-BatchOne-PhaseOne-Project\\CSharp_DayFour_Projects\\data\\info.txt",
                FileMode.Open, FileAccess.Read))
            {
                Employee employee = (Employee)formatter.Deserialize(fileStream);
                Console.WriteLine("Employee Object Deserialized.");

                return employee;
            }
        }
        class SerializationExample
        {
            static void Main(string[] args)
            {
                Employee employee = new Employee()
                {
                    Name = "Gautam",
                    Salary = 12000,
                    Age = 23
                };
                SerializeDeserialize.Serialize(employee);
                employee = SerializeDeserialize.Deserialize();
                Console.WriteLine("Employee Name : " + employee.Name);
                Console.WriteLine("Employee Salary : " + employee.Salary);
                Console.WriteLine("Employee Age : " + employee.Age);
            }
        }
    }
}
