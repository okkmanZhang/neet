namespace ClassLibrary1
{
    public class _986IntervalListIntersections
    {
        public int[][] IntervalIntersection(int[][] firstList, int[][] secondList)
        {
            int i = 0, j = 0;
            List<int[]> x = new List<int[]>();

            while (i < firstList.Length && j < secondList.Length)
            {
                int a1 = firstList[i][0];
                int a2 = firstList[i][1];
                int b1 = secondList[j][0];
                int b2 = secondList[j][1];

                if (b2 >= a1 && a2 >= b1)
                    x.Add(new int[] { Math.Max(a1, b1), Math.Min(a2, b2) });

                if (b2 < a2)
                    j += 1;
                else
                    i += 1;
            }

            int[][] res = new int[x.Count][];
            for (int y = 0; y < x.Count; y++)
            {
                res[y] = x[y];
            }

            return res;
        }
    }
}