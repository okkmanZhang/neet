using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Tests
{
    [TestClass()]
    public class LinqTest
    {

        //[TestMethod()]
        //public void TestSortedDictionary()
        //{
        //    SortedDictionary<int, string> sd = new SortedDictionary<int, string>();

        //    sd[100] = "p100";
        //    sd[10] = "p10";//
        //    sd[1] = "p1";//
        //    sd[20] = "p20";
        //    sd[30] = "p30";
        //    sd[10] = "p10";//

        //    foreach(var i in sd.Take(3))
        //    {
        //        Console.WriteLine(i);
        //    }

        //    Console.WriteLine();

        //    foreach (var i in sd)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}

/*        [TestMethod()]
        public void TestPriorityQueue()
        {
            //Array MulitpleDiamision

            PriorityQueue<string, int> pq = new PriorityQueue<string, int>();

            Action<string, int> AddToPQ = (el, pr) =>
            {
                if (pq.Count >= 3)
                {
                    pq.Dequeue();
                }
                pq.Enqueue(el, pr);
            };

            AddToPQ("p100", 100);
            AddToPQ("p10", 10);//
            AddToPQ("p1", 1);//
            AddToPQ("p20", 20);
            AddToPQ("p30", 30);
            AddToPQ("p10", 10);//

            while(pq.TryDequeue(out string el, out int pr) == true)
            {
                Console.WriteLine($"{el} {pr}");
            }
            //

            SortedDictionary<string, int> sd = new SortedDictionary<string, int>();

        }*/

       /* [TestMethod()]
        public void Grouptest()
        {
            string[] votes = { "cat", "dog", "cat", "ant", "cat", "dog", "dog", "dog", "dog", "dog" };

            var query = from vote in votes
                    group vote by vote into g
                    select g;


            Console.WriteLine("group by string");
            foreach(var g in query)
            {
                Console.WriteLine(g.Key);
                foreach(var c in g)
                {
                    Console.WriteLine(" " + c);
                }
            }


            Console.WriteLine("winner of votes");
            var winner = (from vote in votes
                         group vote by vote into g
                         orderby g.Count() descending
                         select g.Key).FirstOrDefault();

            Console.WriteLine($"winner: {winner}");

            Console.WriteLine("votes list");
            var voteList = (from vote in votes
                            group vote by vote into g
                            orderby g.Count() descending
                            select new { k = g.Key, c = g.Count()}).ToDictionary(p => p.k);

            foreach(var d in voteList.Keys)
            {
                Console.WriteLine($"{d} {voteList[d]}");
            }

        }*/
    }
}