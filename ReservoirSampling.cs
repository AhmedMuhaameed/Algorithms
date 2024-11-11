using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Project
{
    public class ReservoirSampling
    {
        public List<double> Sample(List<double> stream, int k)
        {
            Random random = new Random();
            List<double> reservoir = new List<double>();
            int count = 0;

            foreach (var item in stream)
            {
                count++;

                if (count <= k)
                {
                    // Initially fill the reservoir
                    reservoir.Add(item);
                }
                else
                {
                    // Replace elements with a decreasing probability
                    int j = random.Next(count); // Generate a random index between 0 and count-1
                    if (j < k)
                    {
                        reservoir[j] = item; // Replace the j-th element
                    }
                }
            }

            return reservoir;
        }
    }
}
