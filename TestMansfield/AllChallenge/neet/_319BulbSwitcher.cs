public class _319BulbSwitcher
{
    public int BulbSwitch(int n)
    {
        if (n==0) return 0;
        if (n<=3) return 1;
        return (int)Math.Sqrt(n);

    }
}