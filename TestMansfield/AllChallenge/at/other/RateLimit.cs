using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllChallenge.at
{
    /*
     [input]
     2 requests per minute.
     [timestamp, userId]
     requests: [1:01 01, user1], [1:01 02, user1], [1:01 03, user1], [1:02 01, user1]
    
    [output]
    true, true, false, true

    explanation:
    1:01 01 before rate = 2 after rate = 1 : true
    1.01 02 before rate =1 after rate = 0 : true
    1:01 03 rate = 0 : false
    1:02 01 rate refilled to 2: true
     */

    //change interval, rate
    //thread safe (concurrent collections, synchronized code region lock/monitor)
    //Parallel (TPL/PLINQ, task partition/merge)    


    public class RateData
    {
        public DateTime Timestamp { get; set; }
        public int Rate { get; set; }
    }

    public class RateLimit
    {
        private readonly int _maxRequestCount;
        private readonly int _minuteInterval;
        //<userid, currentTimestamp>
        private Dictionary<string, RateData> _limits = new Dictionary<string, RateData>();
        public RateLimit(int minuteInterval, int maxRequestCount)
        {
            _maxRequestCount = maxRequestCount;
            _minuteInterval = minuteInterval;
        }

        public bool Allow(DateTime timestamp, string userId)
        {
            if (_limits.TryGetValue(userId, out RateData rateData))
            {
                //if the timestamp within the interval
                if(timestamp <= rateData.Timestamp.AddMinutes(_minuteInterval))
                {
                    if (rateData.Rate > 0)
                    {
                        rateData.Rate--;
                        return true;
                    } 
                    else
                    {
                        return false;
                    }

                } else
                {
                    //refill
                    rateData.Rate = _maxRequestCount;
                    rateData.Timestamp = DateTime.Now;
                    rateData.Rate--;
                    return true;
                }
            }
            else
            {
                _limits[userId] = new RateData { Timestamp= DateTime.Now, Rate = _maxRequestCount};
                _limits[userId].Rate--;
                return true;
            }
        }
    }
}
