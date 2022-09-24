namespace ClassLibrary1
{
    public class _77Combinations
    {

        IList<IList<int>> res = new List<IList<int>>();
        public IList<IList<int>> Combine(int n, int k)
        {

            IList<int> current = new List<int>();
            int[] optionList = Enumerable.Range(1,n).ToArray();
            Backtrack(current, optionList, k);
            return res;
        }

        private void Backtrack(IList<int> current, int[] optionList, int k)
        {
            if (current.Count() == k)
            {
                res.Add(new List<int>(current));
                return;
            }

            for (int i = 0; i < optionList.Count(); i++)
            {
                if (current.Contains(optionList[i])) continue;
                

                current.Add(optionList[i]);
                Backtrack(current, optionList.Where(s=> s>optionList[i]).ToArray(), k);
                current.RemoveAt(current.Count() - 1);
            }
        }
    }
}