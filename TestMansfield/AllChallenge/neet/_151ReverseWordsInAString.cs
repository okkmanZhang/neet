using System.Text;

namespace ClassLibrary1
{
    public class _151ReverseWordsInAString
    {
        public string ReverseWords(string s)
        {
            
            var strs = s.Split(' ').Where(a => !String.IsNullOrEmpty(a)).ToArray();

            StringBuilder res = new StringBuilder();
            string[] r = new string[strs.Count()];

            for (int i = strs.Count() -1, j =0; i >=0 ; i--, j++)
            {
                r[j]=strs[i];
            }

            return string.Join(" ", r);

        }
    }
}