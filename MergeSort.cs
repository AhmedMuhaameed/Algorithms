using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Test_Project
{
    public class MergeSort
    {
        public List<double> sort(List<double> arr)
        {
            if (arr.Count < 2) return arr;

            List<double>[] parts = { new List<double>(), new List<double>() };

            for (int i = 0; i < arr.Count; i++)
            {
                parts[i % 2].Add(arr[i]);

            }
            // Recursively sort each part
            parts[0] = sort(parts[0]);
            parts[1] = sort(parts[1]);

            // Merge the sorted parts
            List<double> result = new List<double>();
            int iIndex = 0, jIndex = 0;
            while (iIndex < parts[0].Count && jIndex < parts[1].Count)
            {
                if (parts[0][iIndex] < parts[1][jIndex])
                {
                    result.Add(parts[0][iIndex++]);
                }
                else
                {
                    result.Add(parts[1][jIndex++]);
                }
            }

            // Add any remaining elements from the first part
            while (iIndex < parts[0].Count)
            {
                result.Add(parts[0][iIndex++]);
            }

            // Add any remaining elements from the second part
            while (jIndex < parts[1].Count)
            {
                result.Add(parts[1][jIndex++]);
            }

            return result;

        }
    }
}
