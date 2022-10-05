public class _66PlusOne
{
    public int[] PlusOne(int[] digits)
    {

        int carried = 0;
        Stack<int> p = new Stack<int>();
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(digits[i]);

            if (i == digits.Length - 1)
            {
                if (digits[i] + 1 > 9)
                {
                    carried = 1;
                    p.Push(digits[i] + 1 - 10);

                }
                else
                {
                    carried = 0;
                    p.Push(digits[i] + 1);
                }

            }
            else
            {
                if( carried == 0 ) {
                    p.Push(digits[i]);
                } else {
                    if (digits[i]+carried>9) {
                        carried = 1;
                        p.Push(digits[i]+carried-10);
                    }else{
                        p.Push(digits[i]+carried);
                        carried = 0;
                    }
                }
            }
        }

        if (carried>0)
            p.Push(1);

        Console.WriteLine(string.Join(",", p.ToArray<int>()));

        return p.ToArray<int>();
    }
}