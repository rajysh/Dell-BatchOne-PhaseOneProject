using System;
using System.Net.Http;

namespace CSharp_DayFour_Projects
{
    class PriceException: Exception
    {
        public PriceException():base("Invalid Price") { }
        public PriceException(string message) : base(message) { }
    }
    class ExceptionHandlingDemoFive
    {
        static void MainMethod(string[] args)
        {
            try
            {
                float sellingPrice, costPrice;
                Console.Write("Enter Selling Price: ");
                sellingPrice = float.Parse(Console.ReadLine());
                Console.Write("Enter Cost Price: ");
                costPrice = float.Parse(Console.ReadLine());

                if (sellingPrice <= 0 || costPrice <= 0)
                {
                    //throw new PriceException("Price cannot be Zero or Less.");
                    throw new PriceException();
                }
                else
                {
                    if (sellingPrice > costPrice)
                    {
                        Console.WriteLine("Profit occurred.");

                    }
                    else if (sellingPrice < costPrice)
                    {
                        Console.WriteLine("Loss occurred.");
                    }
                    else
                    {
                        Console.WriteLine("No Profit, No Loss.");
                    }
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("FormatException: " + ex.Message);
            }
            catch (PriceException ex)
            {
                Console.WriteLine("PriceException: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
