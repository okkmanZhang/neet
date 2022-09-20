using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllChallenge.at.Test1
{

    /*
    requests: timestamp: int[], user: string[]
    timestamp[i], user[i]

    maxRequestPerSecond = 2

    bool Allow(timestamp, userid)

    (hour:minute second millisecond)
    
    [1:02 01] : 2, refill [1:02 02] : 2, 
    [1:02 01 001, 1:02 01 002, 1:02 01 003, 1:02 01 004, 1:02 01 004, 1:02 02 004,]
    [user1, user1, user1, user1]

    result
    []

     */
    public class RateLimiter
    {
        private readonly int _maxRequestPerSecond;
        //<secondsOftime, currentRate>
        private Dictionary<long, int> rateWin = new Dictionary<long, int>();
        public RateLimiter(int maxRequestPerSecond)
        {
            _maxRequestPerSecond = maxRequestPerSecond;
        }

        public bool Allow(long timestamp, string userId)
        {
            if(rateWin.TryGetValue(timestamp, out int currentRate))
            {
                if (currentRate > 0)
                {
                    rateWin[timestamp]--;
                    return true;
                }
                else
                {
                    return false;
                }
            } else
            {
                rateWin[timestamp] = _maxRequestPerSecond;
                rateWin[timestamp]--;
                return true;
            }
        }       
    }
}
