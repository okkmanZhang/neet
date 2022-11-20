namespace ClassLibrary1
{
    public class _354RussianDollEnvelopes
    {
        public int MaxEnvelopes(int[][] envelopes)
        {
            int n = envelopes.Length;

            Array.Sort(envelopes,(a,b)=> 
            {
                return a[0]==b[0] ? b[1]-a[1] : a[0]-b[0]; 
            });

            int[] h = new int[n];
            for (int i = 0; i < n; i++)
            {
                h[i]=envelopes[i][1];
            }

            return LengthOfLIS(h);
        }

        public int LengthOfLIS(int[] nums)
        {
            int[] dp = new int[nums.Length];
            Array.Fill(dp, 1);

            for (int i = 0; i < nums.Length; i++)
            {
                
                for (int j = 0; j < i; j++)
                {
                    if (nums[i] > nums[j])
                    {
                         dp[i]  = Math.Max( dp[i] , dp[j]+1);
                    }
                }               

            }

            int max = 0;
            for (int i = 0; i < dp.Length; i++)
            {
                max = Math.Max(max, dp[i]);
            }

            return max;
        }
    }
}