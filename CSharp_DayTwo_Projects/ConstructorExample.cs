using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DayTwo_Projects
{
    class ConstructorExample
    {
        class StudentConstructor
        {
            //Data Members
            int StudentId;
            string StudentName;
            int StudentAge;
            public static string UniversityName;

            //Default Constructor
            public StudentConstructor()
            {
                this.StudentId = 1001;
                this.StudentName = "King Kochhar";
                this.StudentAge = 23;
            }

            //Parameterized Constructor
            public StudentConstructor(int StudentId, string StudentName, int StudentAge)
            {
                this.StudentId = StudentId;
                this.StudentName = StudentName;
                this.StudentAge = StudentAge;
            }

            //Static Constructor
            static StudentConstructor()
            {
                UniversityName = "Amity University";
            }


            //Copy Constructor
            public StudentConstructor(StudentConstructor st)
            {
                this.StudentId = st.StudentId;
                this.StudentName = st.StudentName;
                this.StudentAge = st.StudentAge;
            }

            //Alternatively, Use Clone instead of Copy Constructor
            public object Clone()
            
            {
                return this.MemberwiseClone();
            }

            public void DisplayDetails()
            {
                Console.WriteLine("Student Details : ");
                Console.WriteLine("Student Id : {0}", this.StudentId);
                Console.WriteLine("Student Name : {0}", this.StudentName);
                Console.WriteLine("Student Age : {0}", this.StudentAge);
                Console.WriteLine("University Name : {0}", StudentConstructor.UniversityName);
            }
        }
        static void MethodExample(string[] args)
        {
            //Console.WriteLine("Hello World!");

            StudentConstructor student1; //Creating a reference variable
            student1 = new StudentConstructor(1001, "King Kochhar", 23);//Creating an object
            student1.DisplayDetails();
            Console.WriteLine($"University Name ----- {StudentConstructor.UniversityName}");
            Console.WriteLine("*****************************************");

            StudentConstructor.UniversityName = "Madurai University";
            //Parameterized Constructor
            StudentConstructor student2 = new StudentConstructor(1003, "King Berlin", 25);

            student2.DisplayDetails();
            Console.WriteLine("*****************************************");

            //Copy Constructor
            StudentConstructor student3 = new StudentConstructor(student1);
            student3.DisplayDetails();
            Console.WriteLine("*****************************************");

            //Alternatively, Use Clone instead of Copy Constructor
            StudentConstructor student4 = student2.Clone() as StudentConstructor;
            student4.DisplayDetails();

            Console.ReadKey();
        }
    }    
}
