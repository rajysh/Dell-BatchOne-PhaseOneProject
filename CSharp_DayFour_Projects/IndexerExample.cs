using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DayFour_Projects
{
    class TemperatureRecord
    {
        private float[] temperatures = new float[5] {56.2F, 56.7F, 56.5F, 56.9F, 58.8F };

        public int Length
        {
            get { return temperatures.Length; }
        }

        public float this[int index]
        {
            get
            {
                if (index < Length)
                {
                    return temperatures[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("Index should be in range of 0-4");
                }
            }
            set
            {
                if (index < Length)
                {
                    temperatures[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Index should be in range of 0-4");
                }
            }
        }
    }
    class IndexerExample
    {
        static void MainMethod(string[] args)
        {
            TemperatureRecord temperatureRecord = new TemperatureRecord();
            try
            {
                temperatureRecord[0] = 89.0f;
                temperatureRecord[1] = 90.6f;
                //temperatureRecord[7] = 58.97f;
                for (int i= 0; i < temperatureRecord.Length; i++)
                {
                    Console.WriteLine("\nElement #{0} : {1}", i, temperatureRecord[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
