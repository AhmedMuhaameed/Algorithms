using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Project
{
    public class MaxSubarraySum
    {
        public double maxSubarraySum(List<double> elements,int l,int r)
        {
            if(l > r) return int.MinValue;
            if(l == r) return elements[l];

            int m = (l + r) / 2;
            return Math.Max(

            maxCrossingSub(elements, l, m, r),
            Math.Max(maxSubarraySum(elements, l, m), maxSubarraySum(elements, m + 1, r))
        
            );

        }

        public double maxCrossingSub(List<double> elements,int l,int m ,int r)
        {
            double sum = 0;
            double leftSum = int.MinValue;
            //Left of mid
            for(int i = m; i >= l; i--)
            {
                sum += elements[i];
                if(sum > leftSum)
                {
                    leftSum = sum;
                }
            }
            sum = 0;
            double rightSum = int.MinValue;
            //right of mid
            for (int i=m; i <= r; i++)
            {
                sum += elements[i];
                if (sum > rightSum)
                {
                    rightSum = sum;
                }
            }
            return Math.Max(leftSum + rightSum - elements[m], Math.Max(leftSum, rightSum));

        }
    }
}
