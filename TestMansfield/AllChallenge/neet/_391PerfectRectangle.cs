namespace ClassLibrary1
{
    public class _391PerfectRectangle
    {
        public bool IsRectangleCover(int[][] rectangles)
        {
            int X1 = int.MaxValue, Y1 = int.MaxValue, X2 = int.MinValue, Y2 = int.MinValue;
            HashSet<string> points = new HashSet<string>();
            int actualArea = 0;

            foreach (var item in rectangles)
            {
                int x1 = item[0], y1 = item[1], x2 = item[2], y2 = item[3];
                X1 = Math.Min(X1, x1);
                Y1 = Math.Min(Y1, y1);
                X2 = Math.Max(X2, x2);
                Y2 = Math.Max(Y2, y2);
                actualArea += (x2 - x1) * (y2 - y1);

                int[] p1 = new int[] { x1, y1 }, p2 = new int[] { x1, y2 }, p3 = new int[] { x2, y1 }, p4 = new int[] { x2, y2 };
                foreach (var p in new int[][] { p1, p2, p3, p4 })
                {
                    string s = p[0] + "," + p[1];
                    if (points.Contains(s))
                    {
                        points.Remove(s);
                    }
                    else
                    {
                        points.Add(s);
                    }
                }
            }

            int expectedArea = (X2 - X1) * (Y2 - Y1);
            if (actualArea != expectedArea)
            {
                return false;
            }

            if (points.Count != 4) return false;

            string s1 = X1 + "," + Y1, s2 = X1 + "," + Y2, s3 = X2 + "," + Y1, s4 = X2 + "," + Y2;
            if (!points.Contains(s1)) return false;
            if (!points.Contains(s2)) return false;
            if (!points.Contains(s3)) return false;
            if (!points.Contains(s4)) return false;

            return true;
        }
    }
}