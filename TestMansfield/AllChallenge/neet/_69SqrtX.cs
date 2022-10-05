public class _69SqrtX {
    public int MySqrt(int x) {
        
        if (x==0)
            return 0;

        long l = 0, r = x;        
        
        while (l<=r)
        {
            long mid = l+(r-l)/2;

            if ( mid*mid < x ){
                l = mid+1;
            }else if (mid*mid > x) {
                r = mid-1;
            }else if (mid*mid == x)
            {
                return (int)mid;
            }

        }
        
        return (int)r;
    }
}