namespace ClassLibrary1
{
    public class NumMatrix
    {
        private int[][] preSum;
        public NumMatrix(int[][] matrix)
        {
            int m = matrix.Length, n = matrix[0].Length;

            if (m == 0 || n == 0) return;
            preSum = new int[m + 1][];
            for (int i = 0; i <= m; i++)
            {
                preSum[i] = new int[n + 1];
            }
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    preSum[i][j] = preSum[i - 1][j] + preSum[i][j - 1] + matrix[i - 1][j - 1] - preSum[i - 1][j - 1];
                }
            }

        }

        public int SumRegion(int row1, int col1, int row2, int col2)
        {
            return preSum[row2 + 1][col2 + 1] - preSum[row1][col2 + 1] - preSum[row2 + 1][col1] + preSum[row1][col1];
            
        }
    }
}