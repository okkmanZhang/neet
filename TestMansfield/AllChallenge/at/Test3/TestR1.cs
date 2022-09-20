using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllChallenge.at.Test3
{
    /*
     input:
        2 requests per minute
        [9.14 01, 9.14 02, 9.14 03, 9.15 02]
        [user1, user1, user1, user1]
        [true, true, false, true]
     */

    public class RateData
    {
        public int Rate { get; set; }
        public DateTime StartTime { get; set; }
    }

    public class TestR1
    {
        //<userid, rateData>
        Dictionary<string, RateData> userRateMap = new Dictionary<string, RateData>();
        private readonly int _maxRequestPerMinute = 0;

        public TestR1(int maxRequestPerMinute)
        {
            _maxRequestPerMinute = maxRequestPerMinute;
        }

        public bool Allow(DateTime timestamp, string userId)
        {
            if (userRateMap.TryGetValue(userId, out RateData rateDate))
            {
                //in time slot
                if (timestamp <= rateDate.StartTime.AddMinutes(1))
                {
                    if (rateDate.Rate > 0)
                    {
                        rateDate.Rate--;
                        return true;
                    }else
                    {
                        return false;
                    }
                } else
                {
                    //refresh rateData
                    rateDate.Rate = _maxRequestPerMinute;
                    rateDate.StartTime = timestamp;
                    rateDate.Rate--;
                    return true;
                }
            } else
            {
                //init
                userRateMap[userId] = new RateData { Rate = _maxRequestPerMinute, StartTime = timestamp };
                userRateMap[userId].Rate--;
                return true;
            }
        }
    }
}
