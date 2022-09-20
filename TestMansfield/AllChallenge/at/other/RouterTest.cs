using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllChallenge.at
{
    /*          
    [input]
    url
     template: /entity/action/id
     sample1: /A/Add
     sample2: /B/Get     
    [output]
       routerService
        A.Add
        B.Get
     */
    public class Router
    {        
        private RouteHandler _handler { get; set; }
        public Router(RouteHandler handler)
        {
            _handler = handler;
        }
        public string Route()
        {
            return _handler.Exec();
        }
    }

    public class RouteHandler
    {
        private readonly string _message;
        public RouteHandler(string message)
        {
            _message = message;
        }
        public string Exec()
        {
            return _message;
        }
    }

    public class RouteService
    {
        private Dictionary<string, Router> _routes;
        public RouteService(Dictionary<string, Router> routes)
        {
            _routes = routes;
        }

        public string Route(string url)
        {
            return GetRouter(url).Route();
        }

        private Router? GetRouter(string url)
        {
            var urlSections = url.Split('/');
            var entity = urlSections[1];
            var action = urlSections[2];

            var key = $"{entity}/{action}";
            if (_routes.TryGetValue(key, out Router? router))
            {
                return router;
            }
            else
            {
                return null;
            }
        }
    }

    public class RouteBuilder
    {
        private Dictionary<string, Router> Routes { get; } = new Dictionary<string, Router>();
        public void MapRoute(string commandName, Router router)
        {
            Routes.Add(commandName, router);
        }
        public RouteService Build()
        {
            return new RouteService(Routes);
        }
    }
}
