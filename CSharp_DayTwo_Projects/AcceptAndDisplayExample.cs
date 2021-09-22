using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DayTwo_Projects
{
    class Student
    {
        //Data Members
        protected int StudentId;
        protected string StudentName;
        protected int StudentAge;
        protected static string UniversityName;

        //Static Constructor
        static Student()
        {
            UniversityName = "Amity University";
        }

        //Member Function
        protected void DisplayDetails()
        {
            Console.WriteLine("Student Details : ");
            Console.WriteLine("Student Id : {0}", this.StudentId);
            Console.WriteLine("Student Name : {0}", this.StudentName);
            Console.WriteLine("Student Age : {0}", this.StudentAge);
            Console.WriteLine("University Name : {0}", Student.UniversityName);
        }

        protected void AcceptDetails()
        {
            Console.WriteLine("*************************");
            Console.WriteLine("*************************");
            Console.WriteLine("Student Details : ");
            Console.Write("Enter Student Id : ");
            this.StudentId = int.Parse(Console.ReadLine());
            Console.Write("Enter Student Name : ");
            this.StudentName = Console.ReadLine();
            Console.Write("Enter Student Age : ");
            this.StudentAge = int.Parse(Console.ReadLine());
        }
    }

    class Marks: Student
    {
        //Data Members
        protected float ObjectiveMarks, SubjectiveMarks;

        //Member Function
        protected new void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("*************************");
            Console.WriteLine("Marks Details : ");
            Console.WriteLine("Objective Marks : {0}", ObjectiveMarks.ToString());
            Console.WriteLine("Subjective Marks : {0}", SubjectiveMarks.ToString());
        }

        protected new  void AcceptDetails()
        {
            base.AcceptDetails();
            Console.WriteLine("*************************");
            Console.WriteLine("Marks Details : ");
            Console.Write("Enter Objective Marks : ");
            this.ObjectiveMarks = float.Parse(Console.ReadLine());
            Console.Write("Enter Subjective Marks : ");
            this.SubjectiveMarks = float.Parse(Console.ReadLine());
        }
    }

    class Sports : Marks
    {
        //Data Members
        protected float score;

        //Member Function
        public new void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("*************************");
            Console.Write("Sports Score :  {0}", this.score);
        }

        public new void AcceptDetails()
        {
            base.AcceptDetails();
            Console.WriteLine("*************************");
            Console.WriteLine("Marks Details : ");
            Console.Write("Enter Sports Score : ");
            this.score = float.Parse(Console.ReadLine());
        }
    }

    class Result : Sports
    {
        float TotalMarks, AverageMarks;
        public void Calculate()
        {
            this.TotalMarks = this.ObjectiveMarks + this.SubjectiveMarks + score;
            this.AverageMarks = (this.ObjectiveMarks + this.SubjectiveMarks + score) / 3;
            Console.WriteLine("*************************");
            Console.WriteLine("Total Marks :  {0}", this.TotalMarks);
            Console.WriteLine("Average Marks :  {0}", this.AverageMarks);
        }
    }

    class AcceptAndDisplayExample
    {
        
        static void Main(string[] args)
        {
            //Student student1 = new Student();
            //student1.AcceptDetails();
            //student1.DisplayDetails();

            //Marks marks = new Marks();
            //marks.AcceptDetails();
            //marks.DisplayDetails();

            //Sports sports = new Sports();
            //sports.AcceptDetails();
            //sports.DisplayDetails();

            Result result = new Result();
            result.AcceptDetails();
            result.DisplayDetails();
            result.Calculate();
            Console.ReadKey();
        }
    }    
}
