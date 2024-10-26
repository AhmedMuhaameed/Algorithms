using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Project
{
    public class InsertionSort
    {
        public List<double> sort(List<double> arr)
        {
            int n = arr.Count;
            for (int i = 1; i < n; i++)
            {
                double key = arr[i];
                int j = i - 1;

                /* Move elements of arr[0..i-1], that are
                   greater than key, to one position ahead
                   of their current position */
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
            return arr;
        }

    }
}
