using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DayFour_Projects
{
    class StreamWriterExample
    {
        static void MainMethod(string[] args)
        {
            using (FileStream fileStream = 
                new FileStream("C:\\Users\\rajesh_b2\\OneDrive - Dell Technologies\\Work\\FSD\\Projects\\PhaseOne\\CSharp Basics\\Dell-BatchOne-PhaseOne-Project\\CSharp_DayFour_Projects\\data\\info.txt", 
                FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter streamWriter = new StreamWriter(fileStream))
                {
                    streamWriter.WriteLine("Hello Everyone.");
                    streamWriter.WriteLine("Let's learn File Handling.");                    
                    Console.WriteLine("Content written to file successfully.");
                }
            }
        }
    }
}
