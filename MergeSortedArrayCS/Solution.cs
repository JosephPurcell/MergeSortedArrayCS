using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortedArrayCS
{

        // Leetcode results
        //Runtime - 97ms. Beats 75.23% of users with C#
        //Memory - 45.55MB. Beats 95.53% of users with C#


    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            // move num1 values into a temporary array and make num1 the output array
            // walk through nums2[] and tempNums1[] comparing current values of each
            // copy smaller value to the nums1[] and increment indices of nums1[] and
            // the array which was copied from

            int tempNum1Index = 0;
            int num1Index = 0;
            int num2Index = 0;

            int[] tempNum1 = new int[m];
            for(int i = 0;i<m; i++)
            {
                tempNum1[i] = nums1[i];
            }

            while((tempNum1Index < m) && (num2Index < n))
            {
                if (tempNum1[tempNum1Index] < nums2[num2Index])
                {
                    nums1[num1Index++] = tempNum1[tempNum1Index++];
                }
                else
                {
                    nums1[num1Index++] = nums2[num2Index++];
                }
            }

            while (tempNum1Index < m)
            {
                nums1[num1Index++] = tempNum1[tempNum1Index++];
            }

            while (num2Index < n)
            {
                nums1[num1Index++] = nums2[num2Index++];
            }

            return;
        }
    }
}
