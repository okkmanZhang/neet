public class _0202HappyNumber
{
    public bool IsHappy(int n)
    {
        string nStr = n.ToString();
        int x = n;
        HashSet<int> hh = new HashSet<int>();

        while (1 == 1)
        {
            x = 0;
            for (int i = 0; i < nStr.Length; i++)
            {
                int p = Convert.ToInt32(nStr[i].ToString());
                x += p * p;
            }

            if (x == 1)
                return true;
            else
            {
                if (hh.Contains(x))
                {
                    return false;
                }
                else
                {
                    nStr = x.ToString();
                    hh.Add(x);
                }
            }
        }
    }
}