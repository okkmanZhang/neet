using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class _359LoggerRateLimiter
    {
        private readonly int THRESHOLD_SEC = 10;
        private Dictionary<string, int> _nextTimestamps = new Dictionary<string, int>();
        
        public _359LoggerRateLimiter()
        {
            
        }

        public bool ShouldPrintMessage(int timestamp, string message)
        {
            if (!_nextTimestamps.ContainsKey(message))
            {
                _nextTimestamps.Add(message, timestamp + THRESHOLD_SEC);
                return true;
            }
            else
            {
                if( timestamp >= _nextTimestamps[message])
                {
                    _nextTimestamps[message] = timestamp + THRESHOLD_SEC;
                    return true;
                }else
                {
                    return false;
                }
            }

            return false;
        }
    }
}
