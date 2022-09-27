namespace ClassLibrary1
{
    public class _39CombinationSum
    {

        IList<IList<int>> res = new List<IList<int>>();
        IList<int> track = new List<int>();
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            Backtrack(candidates, 0, target);
            return res;
        }

        private void Backtrack(int[] candidates, int start, int target)
        {
            if (track.Sum() == target)
            {
                res.Add(new List<int>(track));
                return;
            }

            if (track.Sum() > target)
            {
                return;
            }

            for (int i = start; i < candidates.Count(); i++)
            {
                track.Add(candidates[i]);
                Backtrack(candidates, i, target);
                track.RemoveAt(track.Count() - 1);
            }
        }
    }
}