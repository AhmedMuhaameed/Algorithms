using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Project
{
    public class QuickSort
    {
        public List<int> Sort(List<int> arr)
        {
            if (arr.Count < 2)
                return arr;

            Random random = new Random();
            int p = random.Next(arr.Count); // Get a random index for the pivot
            List<int> ls = new List<int>(); // Less than pivot
            List<int> ge = new List<int>(); // Greater than or equal to pivot

            for (int i = 0; i < arr.Count; i++)
            {
                if (i != p) // we shouldn't insert pivot selected in any of the arrays
                {
                    if (arr[i] < arr[p])
                        ls.Add(arr[i]); // Add to less than list
                    else
                        ge.Add(arr[i]); // Add to greater than or equal list
                }
            }

            ls = Sort(ls); // Recursively sort the less than list
            ge = Sort(ge); // Recursively sort the greater than or equal list

            ls.Add(arr[p]); // Add pivot to the sorted list
            ls.AddRange(ge);

            return ls;
        }
    }
}
