using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllChallenge.linq
{
    public class FilterTest
    {
        public static void Run()
        {
            var customers = ExampleDB.Customers.Where(x => x.Name.EndsWith("0")).Select(s => s.Name);
            var r1 = string.Join(',', customers);
            Console.WriteLine( $"where: {r1}");

            var mSelect = ExampleDB.CustomerPurchases.Select(m => m.Purchases);

            var m = ExampleDB.CustomerPurchases.SelectMany(m => m.Purchases);
            var r2 = string.Join(',', m.Select(m => m.Description));
            Console.WriteLine("selectMany  " + r2);

            var mParent = ExampleDB.CustomerPurchases.SelectMany(m => m.Purchases, 
                (p,c) => new {p.ID, c.Description});
            var rParent2 = string.Join(',', mParent.Select(m => $"{m.ID} - {m.Description}"));
            Console.WriteLine("selectMany p-c: " + rParent2);

            string[] files = { "test.jpg", "demo.bmp", "test2.jpg", "demo2.bmp", "readme.txt" };
            var groups = files.GroupBy(f => f.Substring(f.Length -3, 3 ));
            Console.WriteLine("Group:");
            foreach (var k in groups)
            {
                Console.WriteLine(k.Key);
                foreach(var n in k)
                {
                    Console.WriteLine(" " + n);
                }
            }

            Console.WriteLine("selectMany groups:");
            var groupM = groups.SelectMany(m => m);
            foreach(var gm in groupM)
            {
                Console.WriteLine(gm);
            }
        }
    }
}
