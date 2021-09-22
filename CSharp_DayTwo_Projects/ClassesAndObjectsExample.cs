using System;

namespace CSharp_DayTwo_Projects
{

    class StudentClass
    {
        public int StudentId;
        public string StudentName;
        public int StudentAge;

        public void DisplayDetails()
        {
            Console.WriteLine("Student Details : ");
            Console.WriteLine("Student Id : {0}", this.StudentId);
            Console.WriteLine("Student Name : {0}", this.StudentName);
            Console.WriteLine("Student Age : {0}", this.StudentAge);
        }
    }
    class ClassesAndObjectsExample
    {
        //static void Main(string[] args)
        static void MethodExample()
        {
            Console.WriteLine("Hello World!");

            StudentClass student1; //Creating a reference variable
            student1 = new StudentClass();//Creating an object
            student1.StudentId = 1001;
            student1.StudentName = "King Kochhar";
            student1.StudentAge = 23;
            student1.DisplayDetails();

            StudentClass student2; //Creating a reference variable
            student2 = new StudentClass();//Creating an object
            student2.StudentId = 1003;
            student2.StudentName = "Gautam Bhalla";
            student2.StudentAge = 23;
            student2.DisplayDetails();

            Console.ReadKey();
        }
    }
}
