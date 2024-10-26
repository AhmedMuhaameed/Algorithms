using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Project
{
    public class Utilites
    {
        public static void printArray(List<double> arr)
        {
            int n = arr.Count;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");

            Console.WriteLine();
        }
        public static List<double> GenerateRandomArray(int size)
        {
            Random random = new Random();
            List<double> arr = new List<double>();

            for (int i = 0; i < size; i++)
            {
                arr.Add(random.Next(0, 1000)); // Random numbers between 0 and 1000
            }

            return arr;
        }
    }
}
