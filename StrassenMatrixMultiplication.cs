using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Project
{
    public class StrassenMatrixMultiplication
    {
        public List<List<double>> Multiply(List<List<double>> A, List<List<double>> B)
        {

            int n = A.Count;

            if (B.Count != n || A[0].Count != n || B[0].Count != n)
                throw new ArgumentException("Matrices A and B must be square and of the same size.");

            if (n == 1)
            {
                return new List<List<double>> { new List<double> { A[0][0] * B[0][0] } };
            }

            // Split matrices into quadrants
            int newSize = n / 2;
            var A11 = CreateSubMatrix(A, 0, 0, newSize);
            var A12 = CreateSubMatrix(A, 0, newSize, newSize);
            var A21 = CreateSubMatrix(A, newSize, 0, newSize);
            var A22 = CreateSubMatrix(A, newSize, newSize, newSize);

            var B11 = CreateSubMatrix(B, 0, 0, newSize);
            var B12 = CreateSubMatrix(B, 0, newSize, newSize);
            var B21 = CreateSubMatrix(B, newSize, 0, newSize);
            var B22 = CreateSubMatrix(B, newSize, newSize, newSize);


            // Calculate M1 to M7
            var M1 = Multiply(Utilites.AddMatrix(A11, A22), Utilites.AddMatrix(B11, B22));
            var M2 = Multiply(Utilites.AddMatrix(A21, A22), B11);
            var M3 = Multiply(A11, Utilites.SubtractMatrix(B12, B22));
            var M4 = Multiply(A22, Utilites.SubtractMatrix(B21, B11));
            var M5 = Multiply(Utilites.AddMatrix(A11, A12), B22);
            var M6 = Multiply(Utilites.SubtractMatrix(A21, A11), Utilites.AddMatrix(B11, B12));
            var M7 = Multiply(Utilites.SubtractMatrix(A12, A22), Utilites.AddMatrix(B21, B22));

            //Calculate output matrices 
            var C11 = Utilites.AddMatrix(Utilites.SubtractMatrix(Utilites.AddMatrix(M1, M4), M5), M7);
            var C12 = Utilites.AddMatrix(M3, M5);
            var C21 = Utilites.AddMatrix(M2, M4);
            var C22 = Utilites.AddMatrix(Utilites.SubtractMatrix(Utilites.AddMatrix(M1, M3), M2), M6);

            return JoinMatrices(C11, C12, C21, C22);
        }

        private List<List<double>> CreateSubMatrix(List<List<double>> matrix, int rowStart, int colStart, int size)
        {
            var subMatrix = new List<List<double>>();
            for (int i = 0; i < size; i++)
            {
                var row = new List<double>();
                for (int j = 0; j < size; j++)
                {
                    row.Add(matrix[rowStart + i][colStart + j]);
                }
                subMatrix.Add(row);
            }
            return subMatrix;
        }

        private List<List<double>> JoinMatrices(List<List<double>> C11, List<List<double>> C12, List<List<double>> C21, List<List<double>> C22)
        {
            int newSize = C11.Count;
            var result = Utilites.CreateZeroMatrix(newSize * 2);

            // Top left
            for (int i = 0; i < newSize; i++)
                for (int j = 0; j < newSize; j++)
                    result[i][j] = C11[i][j];

            // Top right
            for (int i = 0; i < newSize; i++)
                for (int j = 0; j < newSize; j++)
                    result[i][j + newSize] = C12[i][j];

            // Bottom left
            for (int i = 0; i < newSize; i++)
                for (int j = 0; j < newSize; j++)
                    result[i + newSize][j] = C21[i][j];

            // Bottom right
            for (int i = 0; i < newSize; i++)
                for (int j = 0; j < newSize; j++)
                    result[i + newSize][j + newSize] = C22[i][j];

            return result;
        }

    }
}
