namespace ClassLibrary1
{
    public class RandomizedSet
    {

        IList<int> nums = new List<int>();
        Dictionary<int, int> valToIndex = new Dictionary<int, int>();
        public RandomizedSet()
        {

        }

        public bool Insert(int val)
        {
            if (valToIndex.ContainsKey(val)) return false;

            valToIndex.Add(val, nums.Count);
            nums.Add(val);
            return true;

        }

        public bool Remove(int val)
        {
            if (!valToIndex.ContainsKey(val)) return false;

            int index = valToIndex[val];
            valToIndex[nums[nums.Count - 1]] = index;
            nums[index] = nums[nums.Count - 1];
            nums.RemoveAt(nums.Count - 1);
            valToIndex.Remove(val);
            return true;
        }

        public int GetRandom()
        {
            return nums[new Random().Next(nums.Count - 1)];
        }


    }
}