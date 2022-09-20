namespace LeetCodeTony
{
    public class _0013RomanToInteger
    {
        public int RomanToInt(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int> {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };

            int sum = 0;
            for (int i = 0; i < s.Length; i++)
            {

                if ((s[i] == 'I' && i + 1 <= s.Length - 1 && (s[i + 1] == 'V' || s[i + 1] == 'X'))
                    || (s[i] == 'X' && i + 1 <= s.Length - 1 && (s[i + 1] == 'L' || s[i + 1] == 'C'))
                    || (s[i] == 'C' && i + 1 <= s.Length - 1 && (s[i + 1] == 'D' || s[i + 1] == 'M'))
                )
                {
                    sum += dic[s[i + 1]] - dic[s[i]];
                    i++;
                }
                else
                {

                    sum += dic[s[i]];
                }

                Console.Write(s[i]);
            }

            Console.WriteLine();
            return sum;
        }
    }

}