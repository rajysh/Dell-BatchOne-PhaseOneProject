using CSharp_DayThree_ResultLibrary;
using System;

namespace CSharp_DayThree_Projects
{





    //class Sports : Marks
    //{
    //    //Data Members
    //    protected float score;

    //    //Member Function
    //    public new void DisplayDetails()
    //    {
    //        base.DisplayDetails();
    //        Console.WriteLine("*************************");
    //        Console.Write("Sports Score :  {0}", this.score);
    //    }

    //    public new void AcceptDetails()
    //    {
    //        base.AcceptDetails();
    //        Console.WriteLine("*************************");
    //        Console.WriteLine("Marks Details : ");
    //        Console.Write("Enter Sports Score : ");
    //        this.score = float.Parse(Console.ReadLine());
    //    }
    //}

    
    class InheritanceExample : Result
    {
        static void MainMethod(string[] args)
        {
            Result result = new Result();
            result.AcceptDetails();
            result.DisplayDetails();
            result.Calculate();
            Console.ReadKey();
        }
    }
}
