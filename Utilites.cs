using System;
using System.Collections.Generic;
using System.Drawing;
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

        public static List<List<double>> CreateZeroMatrix(int size)
        {
            var zeroMatrix = new List<List<double>>();
            for (int i = 0; i < size; i++)
            {
                zeroMatrix.Add(new List<double>(new double[size]));
            }
            return zeroMatrix;
        }


        public static List<List<double>> AddMatrix(List<List<double>> A, List<List<double>> B)
        {
            int n = A.Count;
            var C = CreateZeroMatrix(n);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    C[i][j] = A[i][j] + B[i][j];
                }
            }
            return C;
        }

        public static List<List<double>> SubtractMatrix(List<List<double>> A, List<List<double>> B)
        {
            int n = A.Count;
            var C = CreateZeroMatrix(n);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    C[i][j] = A[i][j] - B[i][j];
                }
            }
            return C;
        }

        public static void PrintMatrix(List<List<double>> matrix)
        {
            for (int i = 0; i < matrix.Count; i++)
            {
                for (int j = 0; j < matrix[i].Count; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static List<List<double>> GenerateMatrix(int n)
        {
            var matrix = new List<List<double>>();


            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                var row = new List<double>();
                for (int j = 0; j < n; j++)
                {
                    row.Add(random.Next(0,10)); // Random values between 0 and 10
                }
                matrix.Add(row);
            }

            return matrix;
        }
    }
}
