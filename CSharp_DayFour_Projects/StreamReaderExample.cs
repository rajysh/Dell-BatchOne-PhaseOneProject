using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DayFour_Projects
{
    class StreamReaderExample
    {
        static void MainMethod(string[] args)
        {
            using (FileStream fileStream = 
                new FileStream("C:\\Users\\rajesh_b2\\OneDrive - Dell Technologies\\Work\\FSD\\Projects\\PhaseOne\\CSharp Basics\\Dell-BatchOne-PhaseOne-Project\\CSharp_DayFour_Projects\\data\\info.txt", 
                FileMode.Open, FileAccess.Read))
            {
                using (StreamReader streamReader = new StreamReader(fileStream))
                {
                    var data = streamReader.ReadToEnd();
                    Console.WriteLine(data);
                    Console.WriteLine("Content read successfully.");
                }
            }
        }
    }
}
