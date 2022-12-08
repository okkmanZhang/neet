namespace ClassLibrary1
{
    public class _931MinimumFallingPathSum
    {
        int[,] memo;
        public int MinFallingPathSum(int[][] matrix)
        {
            int n = matrix.Length;
            int res = int.MaxValue;
            memo = new int[n,n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    memo[i,j]=88888;
                }
            }

            for (int i = 0; i < n; i++)
            {
                res = Math.Min(res, DP(matrix, n - 1, i));
            }

            return res;
        }

        private int DP(int[][] matrix, int i, int j)
        {
            if (i < 0 || j < 0 || i >= matrix.Length || j >= matrix.Length)
                return 88888;

            if (i == 0)
                return matrix[i][j];
            
            if(memo[i,j]!=88888)
                return memo[i,j];

            memo[i,j] =  matrix[i][j] + Min(DP(matrix, i - 1, j), 
                DP(matrix, i - 1, j - 1), DP(matrix, i - 1, j + 1));

            return memo[i,j];
        }

        private int Min(int i, int j, int h)
        {           

            return Math.Min(i, Math.Min(j, h));
        }
    }
}