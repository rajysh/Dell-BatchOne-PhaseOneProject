using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DayThree_Projects
{
    class Student
    {        
        //public int StudentId { get; set; }
        //public string StudentName { get; set; }

        private int _studentId;
        private string _studentName;
        private int _studentAge;

        public Student()
        {
            _studentId = 1001;
        }

        public int StudentId
        {
            get { return _studentId; }
            //set { _studentId = value; }
        }

        public string StudentName
        {
            //get { return _studentName; }
            set { _studentName = value; }
        }

        public int StudentAge
        {
            get { return _studentAge; }
            set 
            {
                if (value < 18)
                {
                    Console.WriteLine("Age is not valid.");
                }
                else
                {
                    _studentAge = value;
                }
            }
        }


        public void DisplayDetails()
        {
            Console.WriteLine("Student Id : {0}", this._studentId);
            Console.WriteLine("Student Name : {0}", this._studentName);
            Console.WriteLine("Student Age : {0}", this._studentAge);
        }

    }
    class PropertiesExample
    {
        static void MainMethod(string[] args)
        {
            Student student = new Student();
            //student.StudentId = 1001; //Cannot readonly property
            student.StudentName = "King Kochhar";
            student.StudentAge = 17;

            student.DisplayDetails();

        }
    }
}
