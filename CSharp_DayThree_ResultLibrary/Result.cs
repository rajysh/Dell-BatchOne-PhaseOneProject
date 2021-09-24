using CSharp_DayThree_SportsLibrary;
using System;

namespace CSharp_DayThree_ResultLibrary
{
    public class Result : Sports
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
}
