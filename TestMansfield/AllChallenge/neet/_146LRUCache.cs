using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class LRUCache
    {

        Dictionary<int, int> _cache = new Dictionary<int, int>();
        int _capacity;
        
        
        List<int> _leastUsedQueue = new List<int>();

        public LRUCache(int capacity)
        {
            _capacity = capacity;
        }

        public int Get(int key)
        {
            if (_cache.ContainsKey(key))
            {
                //move the used key to the end of the queue
                _leastUsedQueue.Remove(key);
                _leastUsedQueue = _leastUsedQueue.Append(key).ToList();
                return _cache[key];
            }else
            {
                return -1;
            }
        }

        public void Put(int key, int value)
        {
            if (_cache.ContainsKey(key))
            {
                _leastUsedQueue.Remove(key);
                _leastUsedQueue = _leastUsedQueue.Append(key).ToList();
                _cache[key] = value;
            }else
            {
                if (_cache.Keys.Count == _capacity)
                {
                    var leastKey = _leastUsedQueue[0];
                    _cache.Remove(leastKey);
                    _leastUsedQueue.Remove(leastKey);

                }

                _cache.Add(key, value);
                _leastUsedQueue = _leastUsedQueue.Append(key).ToList();
            }
        }
    }
}
