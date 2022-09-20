using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class _362DesignHitCounter
    {
        //tim
        private readonly List<int> hitTimes = new List<int>();
        private readonly int hitScope = 300; //300 secs.

        public _362DesignHitCounter()
        {

        }

        public void Hit(int timestamp)
        {
            hitTimes.Add(timestamp);
        }

        public int GetHits(int timestamp)
        {
            //Linq
            //return hitTimes.Where(t => t > timestamp - hitScope && t <= timestamp).Count();
            return hitTimes.FindAll(t => t > timestamp - hitScope && t <= timestamp).Count();
        }
    }
}
