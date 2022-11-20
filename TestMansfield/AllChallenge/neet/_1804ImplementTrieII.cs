namespace ClassLibrary1
{
    public class _1804ImplementTrieII
    {

        TrieMap<int> map = new TrieMap<int>();
        public void Insert(string word)
        {
            map.Put(word, map.ContainsKey(word) ? map.Get(word) + 1 : 1);
        }

        public int CountWordsEqualTo(string word)
        {
            return map.Get(word);
        }

        public int CountWordsStartingWith(string prefix)
        {
            int res = 0;
            foreach (var item in map.KeysWithPrefix(prefix))
            {
                res += map.Get(item);
            }
            return res;
        }

        public void Erase(string word)
        {
            int freq = map.Get(word);
            if (freq - 1 == 0)
            {
                map.Remove(word);
            }
            else
            {
                map.Put(word, freq - 1);
            }
        }


    }
}