using System.Text;

namespace ClassLibrary1
{
    public class _648ReplaceWords
    {

        public string ReplaceWords(IList<string> dictionary, string sentence)
        {

            TrieSet set = new TrieSet();
            foreach (var item in dictionary)
            {
                set.Add(item);
            }

            StringBuilder sb = new StringBuilder();
            string[] words = sentence.Split(" ");
            for (int i = 0; i < words.Length; i++)
            {
                string prefix = set.ShortestPrefixOf(words[i]);
                if (!string.IsNullOrEmpty(prefix))
                {
                    sb.Append(prefix);
                }
                else
                {
                    sb.Append(words[i]);
                }

                if (i != words.Length - 1)
                {
                    sb.Append(' ');
                }
            }

            return sb.ToString();

        }
    }
}