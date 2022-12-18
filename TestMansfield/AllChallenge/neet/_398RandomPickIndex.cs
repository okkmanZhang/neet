namespace ClassLibrary1
{
    public class _398RandomPickIndex
    {
        Random rd;
        Dictionary<int, List<int>> numIndexs = new Dictionary<int, List<int>>();
        public _398RandomPickIndex(int[] nums)
        {
            rd = new Random();
            
            for (int i = 0; i < nums.Length; i++)
            {
                if(numIndexs.ContainsKey(nums[i]))
                {
                    numIndexs[nums[i]].Add(i);
                }else{
                    numIndexs.Add(nums[i], new List<int>{i});
                }
            }
        }

        public int Pick(int target)
        {
            var List = numIndexs[target].ToArray();
            
            return List[rd.Next(List.Length)];
        }


    }
}