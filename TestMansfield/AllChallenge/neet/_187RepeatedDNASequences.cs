namespace ClassLibrary1
{
    public class _187RepeatedDNASequences
    {
        public IList<string> FindRepeatedDnaSequences(string s)
        {

            Dictionary<string, int> res = new Dictionary<string, int>();
            int len = 10;
        

            //11-10-1=

            for (int i = 0; i < s.Length - 9; i++)
            {
                var current = s.Substring(i, len);

                if (res.ContainsKey(current))
                {
                    res[current]++;
                }
                else
                {
                    res.Add(current, 1);
                }
            }

            IList<string> r = new List<string>();

            foreach (var item in res)
            {
                if (item.Value >= 2)
                {
                    r.Add(item.Key);
                }
            }

            return r.ToArray();

        }
    }
}