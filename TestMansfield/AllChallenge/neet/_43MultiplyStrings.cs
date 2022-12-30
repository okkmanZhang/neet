namespace ClassLibrary1
{
    public class _43MultiplyStrings
    {
        public string Multiply(string num1, string num2)
        {
            int m = num1.Length, n = num2.Length;
            int[] res = new int[n + m];
            Array.Fill(res, 0);

            for (int i = m - 1; i >= 0; i--)
            {
                for (int j = n - 1; j >= 0; j--)
                {
                    int mul = (num1[i] - '0') * (num2[j] - '0');
                    int p1 = i + j, p2 = i + j + 1;
                    int sum = mul + res[p2];
                    res[p2] = sum % 10;
                    res[p1] += sum / 10;
                }
            }

            if (num1 == "0" || num2 == "0") return "0";

            if (res[0] == 0)
                return string.Join("", res.Skip(1));

            return string.Join("", res);
        }
    }
}