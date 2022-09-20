using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllChallenge
{
    public class _1166DesignFileSystem
    {
        //<path, value>
        private readonly Dictionary<string, int> pathCache = new Dictionary<string, int>();

        public _1166DesignFileSystem()
        {

        }

        public bool CreatePath(string path, int value)
        {
            if (path == "" || path == "/") return false;

            // /leet
            // /leet/code
            // /leet/code/test
            var parentPath = path.Substring(0, path.LastIndexOf('/'));
            if (pathCache.ContainsKey(path)
               || (path.Split('/').Count() > 2
                    && !pathCache.ContainsKey(parentPath)))
            {
                return false;
            }
            else
            {
                pathCache.Add(path, value);
                return true;
            }
        }

        public int Get(string path) => pathCache.ContainsKey(path) ? pathCache[path] : -1;

    }
}
