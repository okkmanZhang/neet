namespace ClassLibrary1
{
    public class _241DifferentWaysToAddParentheses
    {
        public IList<int> DiffWaysToCompute(string expression)
        {
            List<int> res = new List<int>();
            for (int i = 0; i < expression.Length; i++)
            {
                char c = expression[i];
                if (c == '-' || c == '*' || c == '+')
                {
                    IList<int> left = DiffWaysToCompute(expression.Substring(0, i));
                    IList<int> right = DiffWaysToCompute(expression.Substring(i + 1));

                    foreach (var a in left)
                    {
                        foreach (var b in right)
                        {
                            if (c == '+')
                                res.Add(a + b);
                            else if (c == '-')
                                res.Add(a - b);
                            else if (c == '*')
                                res.Add(a * b);
                        }
                    }
                }
            }

            if (res.Count == 0)
                res.Add(int.Parse(expression));

            return res;
        }
    }
}