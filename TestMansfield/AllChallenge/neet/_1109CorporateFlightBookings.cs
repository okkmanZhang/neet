namespace ClassLibrary1
{
    public class _1109CorporateFlightBookings
    {
        public int[] CorpFlightBookings(int[][] bookings, int n)
        {
            int[] res = new int[n];
            Difference diff = new Difference(res);
            for (int i = 0; i < bookings.Length; i++)
            {
                int l = bookings[i][0]-1;
                int r = bookings[i][1]-1;
                int s = bookings[i][2];
                diff.Increment(l,r,s);
            }

            return diff.Result();
        }
    }

}