using System;

namespace CSharp_DaySeven_Misc_Projects
{
    internal class PassByValueAndRefExample
    {
        static void PassByValue(int number)
        {
            number = 200;
        }

        static void PassByReference(ref int number)
        {
            number = 200;
        }

        static void Swap(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("After Swapping in Swap Method.");
            Console.WriteLine("Number One in Swap Method: " + num1);
            Console.WriteLine("Number Two in Swap Method: " + num2);
        }

        static ref int GetFirstOddNumber(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] % 2 == 1)
                    return ref numbers[i];
            }

            throw new Exception("Odd Number not found.");
        }

        static void MainMethod(string[] args)
        {
            ////Pass by Value
            //int num = 100;
            //PassByValue(num);
            //Console.WriteLine("Pass by Value Number in Main Method : " + num);

            ////Pass by Ref
            //PassByReference(ref num);
            //Console.WriteLine("Pass by Ref Number in Main Method : " + num);

            ////Swap Reference number
            //int num1 = 100, num2 = 200;
            //Swap(ref num1, ref num2);
            //Console.WriteLine("After Swapping in Main Method.");
            //Console.WriteLine("Number One in Main Method: " + num1);
            //Console.WriteLine("Number Two in Main Method: " + num2);

            ////Referenc variable
            //int num3 = 100;
            //ref int  num4= ref num3;
            //num4 = 1000;
            //Console.WriteLine("Number 3: " + num3);
            //Console.WriteLine("Number 4: " + num4);

            //Reference Method
            int[] numbers = { 2, 6, 64, 56, 35, 57, 68, 73, 94 };
            ref int oddNum = ref GetFirstOddNumber(numbers);
            Console.WriteLine("Result : "+ oddNum);
            oddNum = 33;
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.ReadKey();

        }
    }
}
