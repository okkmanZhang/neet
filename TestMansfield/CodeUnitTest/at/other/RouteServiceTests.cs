//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using AllChallenge.ot;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace AllChallenge.at.Tests
//{
//    [TestClass()]
//    public class RouteServiceTests
//    {
//        [TestMethod()]
//        public void RouteTest()
//        {
//            RouteBuilder builder = new RouteBuilder();
//            builder.MapRoute("A/Add", new Router(new RouteHandler("A.Add")));
//            builder.MapRoute("B/Get", new Router(new RouteHandler("B.Get")));
//            RouteService routerService = builder.Build();

//            Assert.AreEqual("A.Add", routerService.Route("/A/Add"));
//        }

//        [TestMethod()]
//        public void RouteTest2()
//        {
//            RouteBuilder builder = new RouteBuilder();
//            builder.MapRoute("A/Add", new Router(new RouteHandler("A.Add")));
//            builder.MapRoute("B/Get", new Router(new RouteHandler("B.Get")));
//            RouteService routerService = builder.Build();

//            Assert.AreEqual("B.Get", routerService.Route("/B/Get"));
//        }
//    }
//}