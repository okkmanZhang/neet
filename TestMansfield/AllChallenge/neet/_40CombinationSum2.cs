namespace ClassLibrary1
{
    public class _40CombinationSum2
    {

        IList<IList<int>> res = new List<IList<int>>();
        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            IList<int> track = new List<int>();
            Array.Sort(candidates);
            Backtrack(candidates, track, target);
            return res;
        }

        private void Backtrack(int[] candidates, IList<int> track, int target)
        {
            if (track.Sum() == target)
            {
                res.Add(new List<int>(track));            
                return;    
            }

            if (track.Sum()>target) return;

            for (int i = 0; i < candidates.Count(); i++)
            {
                if( i > 0 && candidates[i] == candidates[i-1]) continue;

                track.Add(candidates[i]);
                Backtrack(candidates.Skip(i+1).ToArray(), track, target);
                track.RemoveAt(track.Count() - 1);
            }
        }
    }
}