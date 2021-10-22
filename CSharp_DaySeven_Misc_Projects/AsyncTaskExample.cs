using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DaySeven_Misc_Projects
{
    internal class AsyncTaskExample
    {
        static async Task<string> ShowInfo()
        {
            return $"Today is {DateTime.Today} \n Today's hours of leisure : {await GetLeisureHours()}";
        }

        private static async Task<int> GetLeisureHours()
        {
            var today = await Task.FromResult<string>(DateTime.Now.DayOfWeek.ToString());
            int leisureHours;

            if (today.First() == 'S')
                leisureHours = 16;
            else
                leisureHours = 5;

            return leisureHours;
        }

        static void MainMethod(string[] args)
        {
            Console.WriteLine(ShowInfo().Result);

            Console.ReadKey();
        }
    }
}
