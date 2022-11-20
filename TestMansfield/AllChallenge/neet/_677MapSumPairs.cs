namespace ClassLibrary1
{
    public class _677MapSumPairs
    {
        TrieMap<int> map = new TrieMap<int>();
        public void Insert(string key, int val)
        {
            if(map.ContainsKey(key))
            {
                map.Remove(key);                
            }
            map.Put(key,val);
        }

        public int Sum(string prefix)
        {
            int res = 0;
            foreach (var item in map.KeysWithPrefix(prefix))
            {
                res+=map.Get(item);
            }

            return res;
        }
    }
}