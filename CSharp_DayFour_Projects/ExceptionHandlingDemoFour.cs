using System;
using System.Net.Http;

namespace CSharp_DayFour_Projects
{
    class ExceptionHandlingDemoFour
    {
        static void MainMethod(string[] args)
        {
            HttpClient client = null;
            try
            {
                //client = new HttpClient();
                var result = client.GetStringAsync("https://www.google.com").Result;
                Console.WriteLine(result.ToString());
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine("NullReferenceException" + ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("FormatException: " + ex.Message);
            }           
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            finally
            {
                client?.Dispose();
            }
            Console.ReadKey();
        }
    }
}
