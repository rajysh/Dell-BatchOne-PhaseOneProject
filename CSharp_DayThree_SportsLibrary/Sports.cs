using CSharp_DayThree_MarksLibray;
using System;

namespace CSharp_DayThree_SportsLibrary
{
    public class Sports : Marks
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
}
