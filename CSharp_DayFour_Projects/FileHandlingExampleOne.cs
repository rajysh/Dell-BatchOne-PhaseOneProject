using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DayFour_Projects
{
    class FileHandlingExampleOne
    {
        static void MainMethod(string[] args)
        {
            //Demonstration One
            //FileStream fileStream = new FileStream(
            //    "C:\\Users\\rajesh_b2\\OneDrive - Dell Technologies\\Work\\FSD\\Projects\\PhaseOne\\CSharp Basics\\Dell-BatchOne-PhaseOne-Project\\CSharp_DayFour_Projects\\data\\info.txt", 
            //    FileMode.Append, FileAccess.Write);
            //Console.WriteLine("File Created Successfully");
            //Byte[] bdata = Encoding.Default.GetBytes("Hello Everyone");
            //fileStream.Write(bdata, 0, bdata.Length);
            //Console.WriteLine("Content Written to the File.");
            //fileStream.Close();

            //Demonstration Two
            FileStream fileStream = new FileStream(
                "C:\\Users\\rajesh_b2\\OneDrive - Dell Technologies\\Work\\FSD\\Projects\\PhaseOne\\CSharp Basics\\Dell-BatchOne-PhaseOne-Project\\CSharp_DayFour_Projects\\data\\info.txt",
                FileMode.Open, FileAccess.Read);
            string data;
            StreamReader streamReader = new StreamReader(fileStream);
            data = streamReader.ReadToEnd();
            Console.WriteLine(data);
            fileStream.Close();
        }
    }
}
