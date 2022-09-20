using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeUnitTest.at.Test3
{
    /*
     
     url
        user/add
        uer/get

    route 
        user/add -> "user.add"
        user/get -> "user.get"
     */

    public class T_handler
    {
        private string _message;
        public T_handler(string message)
        {
            _message = message;
        }

        public string Exec()
        {
            return _message;
        }
    }
         

    public class TestRo1_Router
    {
        private T_handler _handler;
        public TestRo1_Router(T_handler handler)
        {
            _handler = handler;
        }
        public string Route()
        {
            return _handler.Exec();
        }
    }

    public class T_RouterService
    {
        private Dictionary<string, TestRo1_Router> _routerMap;

        public T_RouterService(Dictionary<string, TestRo1_Router> routerMap)
        {
            _routerMap = routerMap;
        }

        public string Route(string url)
        {
            if (_routerMap.TryGetValue(url, out TestRo1_Router router))
            {
                return router.Route();
            } else
            {
                return String.Empty;
            }
        }
    }

    public class RouterBuilder
    {
        Dictionary<string, TestRo1_Router> routerMap = new Dictionary<string, TestRo1_Router>();

        public void MapRouter(string url, TestRo1_Router router)
        {
            routerMap[url] = router;            
        }

        public T_RouterService Build()
        {
            return new T_RouterService(routerMap);
        }
    }
}
