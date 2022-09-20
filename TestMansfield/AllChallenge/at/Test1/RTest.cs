using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllChallenge.at.Test1
{
    /*
      create url router class.
      REST api: {/entity/action/?id}
        /user/add -> A.userAdd()
        /product/get/1 -> B.productGet(id)

     */

    public class RouterData
    {
        public string? Id { get; set; }
    }

    public class RouterHandler
    {
        Action<RouterData> _action;
        public RouterHandler(Action<RouterData> action)
        {
            _action = action;
        }

        public Action<RouterData> GetHandler()
        {
            return _action;
        }
    }

    public class Router
    {
        private RouterHandler _handler;
        public RouterData data { get; set; }
        public Router(RouterHandler handler)
        {
            _handler = handler;        
        }

        

        public void Route()
        {
            _handler.GetHandler().Invoke(data);
        }
    }

    public class Routerbuilder
    {
        //
        Dictionary<string, Router> routerMap = new Dictionary<string, Router>();

        // /user/get/1
        public Routerbuilder()
        {
/*            var segs = url.Split('/');
            var entity = segs[1];
            var action = segs[2];
            var id = segs.Length >= 4 ? segs[3] : null;
            var key = $"/{entity}/{action}";
            var routeData = new RouterData { Id = id };*/

            routerMap["/user/add"] = new Router(new RouterHandler((d) => new A().UserAdd()));
            routerMap["/product/get"] = new Router(new RouterHandler((d) => new B().ProductGet(d.Id)));
        }

        public Router GetRouter(string url)
        {
            var segs = url.Split('/');
            var entity = segs[1];
            var action = segs[2];
            var id = segs.Length >= 4 ? segs[3] : null;
            var key = $"/{entity}/{action}";

            routerMap[key].data = new RouterData { Id = id };

            return routerMap[key];
        }

    }

    public class RouterTest
    {
        public void Run()
        {
            var routerbuilder = new Routerbuilder();

            var router = routerbuilder.GetRouter("/user/add");
            router.Route();

            router = routerbuilder.GetRouter("/product/get/100");
            router.Route();

        }
    }


    public class A
    {
        public void UserAdd()
        {
            Console.WriteLine("A.UserAdd");
        }
    }

    public class B
    {
        public void ProductGet(string id)
        {
            Console.WriteLine($"B.ProductGet({id})");
        }
    }

    public class RTest
    {

    }
}
