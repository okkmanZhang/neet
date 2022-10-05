public class _70ClimbingStairs {
    public int ClimbStairs(int n) {

        if (n==1)
            return 1;
        if (n==2)
            return 2;
        
        int[] x = new int[n+1];     
            x[1] = 1;
            x[2] = 2;



        for (int i = 3; i <= n; i++)
        {
            x[i]  = x[i-1] +x[i-2];            
        }

        //Console.WriteLine( string.Join(",", x));

        return x[n];
    }
}