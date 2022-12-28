namespace ClassLibrary1
{
    public class _1541MinimumInsertionsToBalanceAParenthesesString
    {
        public int MinInsertions(string s)
        {
            int need = 0, res = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    need += 2;
                    if (need % 2 == 1)
                    {
                        res++;
                        need--;
                    }
                }
                else
                {
                    need--;

                    if (need == -1)
                    {
                        res++;
                        need = 1;
                    }
                }
            }

            return res + need;
        }
    }
}