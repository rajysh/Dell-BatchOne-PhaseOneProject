using CSharp_DayThree_StudentLibrary;
using System;

namespace CSharp_DayThree_MarksLibray
{
    public class Marks : Student
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

        protected new void AcceptDetails()
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
}
