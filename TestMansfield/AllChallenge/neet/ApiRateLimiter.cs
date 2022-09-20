using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    /*
 
    Imagine we are building an application that is used by many different customers. 
    We want to avoid one customer being able to overload the system by sending too many requests, 
    so we enforce a per-customer rate limit. The rate limit is defined as:

    “Each customer can make X requests per Y seconds”

    Assuming that customer ID is extracted somehow from the request, implement the following function.


    // Perform rate limiting logic for provided customer ID. Return true if the
    // request is allowed, and false if it is not.
    boolean rateLimit(int customerId)

     
     */

    public class CustomerLimit
    {
        public int CurrentHit { get; set; }
        public long Timestamp { get; set; }
    }

    //fixed window
    public class ApiRateLimiterV1
    {
        private readonly int TIME_SCOPE = 5;
        private readonly int REQUEST_LIMIT = 1;
        private Dictionary<int, CustomerLimit> limitCache = new Dictionary<int, CustomerLimit>();

        public bool RateLimit(int customerId)
        {
            var currentTimestamp = new DateTimeOffset(DateTime.Now).ToUnixTimeSeconds();
            Console.WriteLine(currentTimestamp);
            if (!limitCache.ContainsKey(customerId))
            {
                limitCache.Add(customerId, new CustomerLimit() { CurrentHit = 1, Timestamp = currentTimestamp });
                return true;
            }
            else
            {
                //0 5
                // 3
                if (currentTimestamp - limitCache[customerId].Timestamp <= TIME_SCOPE )
                {
                    if (limitCache[customerId].CurrentHit < REQUEST_LIMIT) 
                    {
                        limitCache[customerId].CurrentHit++;
                        return true;
                    }else
                    {
                        return false;
                    }

                } else
                {
                    limitCache[customerId].CurrentHit = 1;
                    limitCache[customerId].Timestamp = currentTimestamp;
                    return true;
                }
            }
        }
    }

    //queue    

    public class ApiRateLimiterV2
    {
        private readonly int REQUEST_LIMIT = 3;
        private readonly long TIME_SCOPE = 1000L;
        private Dictionary<int, HitCounter> clientTimeMap = new Dictionary<int, HitCounter>();

        public class HitCounter
        {
           public Queue<long> queue = new Queue<long>();
            ApiRateLimiterV2 _parent;
            public HitCounter(ApiRateLimiterV2 parent) { _parent = parent; }
           public bool Hit(long timestamp)
           {
                while (queue.Count() > 0 && timestamp - queue.Peek()  >= _parent.TIME_SCOPE) queue.Dequeue();
                if(queue.Count() < _parent.REQUEST_LIMIT)
                {
                    queue.Enqueue(timestamp);
                    return true;
                }
                return false;
           }            
        }

        public bool RateLimit(int customerId)
        {
            long currentTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            if(!clientTimeMap.ContainsKey(customerId))
            {
                var hit = new HitCounter(this);
                hit.Hit(currentTime);
                clientTimeMap.Add(customerId, hit);

                return true;
            } else
            {
                var hit = clientTimeMap[customerId];
                return hit.Hit(currentTime);
            }
        }
    }
}
