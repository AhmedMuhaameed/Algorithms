using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Project
{
    public class QuickSelect
    {
        public double Select(List<double> arr, int k)
        {
            if (arr.Count == 1)
                return arr[0];
            k = k--;
            Random random = new Random();
            int p = random.Next(arr.Count); // Randomly select pivot
            List<double> ls = new List<double>(); // Less than pivot
            List<double> ge = new List<double>(); // Greater than or equal to pivot

            for (int i = 0; i < arr.Count; i++)
            {
                if (i != p) // Exclude pivot
                {
                    if (arr[i] < arr[p])
                        ls.Add(arr[i]); // Add to less than list
                    else
                        ge.Add(arr[i]); // Add to greater than or equal list
                }
            }

            int pivotRank = ls.Count; // Number of elements smaller than pivot

            if (k == pivotRank) // Pivot is the k-th smallest element
                return arr[p];
            else if (k < pivotRank) // k-th smallest is in the left partition
                return Select(ls, k);
            else // k-th smallest is in the right partition
                return Select(ge, k - pivotRank - 1); // Adjust k for the right partition
        }
    }
}
