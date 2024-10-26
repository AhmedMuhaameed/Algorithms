using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Project
{
    public class BruteForceMatrixMultiplication
    {
        public List<List<double>> Multiply(List<List<double>> A, List<List<double>> B)
        {
            int rowsA = A.Count;
            int colsA = A[0].Count;
            int rowsB = B.Count;
            int colsB = B[0].Count;

            // Ensure the number of columns in A equals the number of rows in B
            if (colsA != rowsB)
            {
                throw new ArgumentException("Number of columns in A must match number of rows in B.");
            }

            // Initialize result matrix with zeros
            var result = new List<List<double>>();
            for (int i = 0; i < rowsA; i++)
            {
                result.Add(new List<double>(new double[colsB])); // Initialize each row with zeros
            }

            // Perform multiplication
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    for (int k = 0; k < colsA; k++)
                    {
                        result[i][j] += A[i][k] * B[k][j];
                    }
                }
            }

            return result;
        }
    }
}
