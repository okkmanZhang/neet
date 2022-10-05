namespace LeetCodeTony
{

    public class _14LongestCommonPrefix
    {
        public string LongestCommonPrefix(string[] strs)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            if (strs.Length == 0)
                return "";

            for (int i = 0; i < strs[0].Length; i++)
            {

                bool isSame = true;

                foreach (string str in strs)
                {
                    if (i + 1 > str.Length || strs[0][i] != str[i])
                        isSame = false;
                }

                if (isSame)
                    sb.Append(strs[0][i]);
                else
                    break;

            }

            return sb.ToString();
        }
    }

}