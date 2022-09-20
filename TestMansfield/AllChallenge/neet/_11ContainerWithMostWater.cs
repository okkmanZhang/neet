using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class _11ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {

            int maxArea = 0;

            if (height.Length == 0) { return 0; }
            if (height.Length == 1) { return 0; }

            int left = 0;
            int right = height.Length - 1;

            while (left < right)
            {

                maxArea = Math.Max(maxArea, this.GetArea(height, left, right));

                if (height[left] > height[right])
                {
                    right--;
                } else
                {
                    left++;
                }


            }


            return maxArea;
        }

        private int GetArea(int[] height, int left, int right)
        {
            var len = right - left;
            var high = Math.Min(height[right], height[left]);
            return len * high;
        }
    }
}
