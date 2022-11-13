namespace ClassLibrary1
{
    public class LFUCache
    {
        int cap;
        int minFreq;
        Dictionary<int, int> keyToVal;
        Dictionary<int, int> KeyToFreq;
        Dictionary<int, LinkedHashMap> freqToKeys;
        LinkedHashMap cache = new LinkedHashMap();
        public LFUCache(int capacity)
        {
            this.cap = capacity;
            this.minFreq = 0;
            keyToVal = new Dictionary<int, int>();
            KeyToFreq = new Dictionary<int, int>();
            freqToKeys = new Dictionary<int, LinkedHashMap>();
        }

        public int Get(int key)
        {
            if (!keyToVal.ContainsKey(key)) return -1;

            IncreaseFreq(key);
            return keyToVal[key];
        }

        public void Put(int key, int value)
        {
            if (this.cap <= 0) return;

            if (keyToVal.ContainsKey(key))
            {
                keyToVal[key] = value;
                IncreaseFreq(key);
                return;
            }

            if (this.cap <= keyToVal.Count())
            {
                RemoveMinFreqKey();
            }

            keyToVal.Add(key, value);
            KeyToFreq.Add(key, 1);

            if (!freqToKeys.ContainsKey(1)) freqToKeys.Add(1, new LinkedHashMap());
            freqToKeys[1].Put(key, key);
            this.minFreq = 1;
        }
        private void RemoveMinFreqKey()
        {
            LinkedHashMap keyList = freqToKeys[this.minFreq];
            int delKey = keyList.HeadKey();

            keyList.Remove(delKey);
            if (keyList.Size() == 0)
            {
                freqToKeys.Remove(this.minFreq);
            }
            keyToVal.Remove(delKey);
            KeyToFreq.Remove(delKey);
        }
        private void IncreaseFreq(int key)
        {
            int freq = keyToVal[key];
            KeyToFreq[key]= freq + 1;
            freqToKeys[freq].Remove(key);

            if (!freqToKeys.ContainsKey(freq + 1)) freqToKeys.Add(freq + 1, new LinkedHashMap());
            freqToKeys[freq + 1].Put(key, key);

            if (freqToKeys[freq].Size() == 0)
            {
                freqToKeys.Remove(freq);

                if (freq == this.minFreq)
                {
                    this.minFreq++;

                }
            }
        }

    }


    // public class LRUCache
    // {
    //     int cap;
    //     LinkedHashMap cache = new LinkedHashMap();
    //     public LRUCache(int capacity)
    //     {
    //         this.cap = capacity;
    //     }

    //     public int Get(int key)
    //     {
    //         if (!cache.ContainsKey(key)) return -1;

    //         MakeRecently(key);
    //         return cache.Get(key);
    //     }

    //     public void Put(int key, int val)
    //     {
    //         if (cache.ContainsKey(key))
    //         {
    //             cache.Put(key, val);
    //             MakeRecently(key);
    //             return;
    //         }
    //         if (cap == cache.Size())
    //         {
    //             cache.Remove(cache.HeadKey());
    //         }
    //         cache.Put(key, val);
    //     }
    //     private void MakeRecently(int key)
    //     {
    //         int val = cache.Get(key);
    //         cache.Remove(key);
    //         cache.Put(key, val);
    //     }
    // }


    public class DoubleListNode
    {
        public int key;
        public int val;
        public DoubleListNode next, prev;
        public DoubleListNode(int k, int v)
        {
            this.key = k;
            this.val = v;
        }
    }

    public class DoubleList
    {
        private DoubleListNode head, tail;
        private int size;

        public DoubleList()
        {
            head = new DoubleListNode(0, 0);
            tail = new DoubleListNode(0, 0);
            head.next = tail;
            tail.prev = head;
            size = 0;
        }

        public void AddLast(DoubleListNode x)
        {
            x.prev = tail.prev;
            x.next = tail;
            tail.prev.next = x;
            tail.prev = x;
            size++;
        }
        public void Remove(DoubleListNode x)
        {
            x.prev.next = x.next;
            x.next.prev = x.prev;
            size--;
        }
        public DoubleListNode RemoveFirst()
        {
            if (head.next == tail)
                return null;

            var first = head.next;
            Remove(first);
            return first;
        }

        public int Size() { return size; }
        public int HeadKey()
        {
            if (head.next == tail)
                return -1;

            return head.next.key;
        }
    }

    public class LinkedHashMap
    {
        private Dictionary<int, DoubleListNode> map;
        private DoubleList cache;

        public LinkedHashMap()
        {
            map = new Dictionary<int, DoubleListNode>();
            cache = new DoubleList();
        }

        public bool ContainsKey(int key)
        {
            return map.ContainsKey(key);
        }

        public void Put(int key, int val)
        {
            if (this.ContainsKey(key)) this.DeleteKey(key);
            this.AddRecently(key, val);
        }

        public int Get(int key)
        {
            if (this.ContainsKey(key)) return map[key].val;
            return -1;
        }

        public int Size()
        {
            return map.Count();
        }

        public void Remove(int key)
        {
            this.DeleteKey(key);
        }

        public int HeadKey()
        {
            return cache.HeadKey();
        }

        private void AddRecently(int key, int val)
        {
            DoubleListNode x = new DoubleListNode(key, val);
            cache.AddLast(x);
            map.Add(key, x);
        }

        private void DeleteKey(int key)
        {
            DoubleListNode x = map[key];
            cache.Remove(x);
            map.Remove(key);
        }

        private void RemoveLeastRecently()
        {
            DoubleListNode del = cache.RemoveFirst();
            int delKey = del.key;
            map.Remove(delKey);
        }

    }

}