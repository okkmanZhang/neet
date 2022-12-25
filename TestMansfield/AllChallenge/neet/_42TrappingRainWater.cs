namespace ClassLibrary1
{
    public class _42TrappingRainWater
    {
        public int Trap(int[] height)
        {
            int n = height.Length;
            int[] l_max = new int[n];
            int[] r_max = new int[n];

            l_max[0] = height[0];
            r_max[n - 1] = height[n - 1];

            for (int i = 1; i < n; i++)
            {                
                l_max[i] = Math.Max(height[i], l_max[i-1]);                
            }
            for (int i = n - 2; i >= 0; i--)
            {
                
                r_max[i] = Math.Max(height[i], r_max[i+1]);
            }

            int res = 0;
            for (int i = 0; i < n; i++)
            {
                int current = Math.Min(l_max[i], r_max[i]) - height[i];
                res += current;
            }

            return res;
        }
    }
}