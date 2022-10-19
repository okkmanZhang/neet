using AllChallenge.ama;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeUnitTest.ama
{
    [TestClass()]
    public class ProductRecommenderTests
    {

        /*

        A: B C
        B: A D
        C: A B
        D: C B A


        A: B C D
        B: A D C
        C: A B C
        D: C B A

        */

        [TestMethod()]
        public void test()
        {
            ProductRecommender.products =
            new Dictionary<string, Product>{
                {"A", new Product{ProductId="A", Suggestions=new List<string>(){"B","C"}}},
                {"B", new Product{ProductId="B", Suggestions=new List<string>(){"A","D"}}},
                {"C", new Product{ProductId="C", Suggestions=new List<string>(){"A","B"}}},
                {"D", new Product{ProductId="D", Suggestions=new List<string>(){"C","B","A"}}},
            };

            foreach (var item in ProductRecommender.products.Values)
            {
                Dictionary<string, Product> res = new Dictionary<string, Product>();
                ProductRecommender.visited = new HashSet<string>();
                ProductRecommender.Suggestions(item,res, item);
                Console.Write(item.ProductId + ": ");
                Console.WriteLine(String.Join(" ", res.Keys));
            }
        }
    }
}