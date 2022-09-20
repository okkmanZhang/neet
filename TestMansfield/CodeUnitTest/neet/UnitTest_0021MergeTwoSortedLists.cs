using System.Collections;
using System.Collections.Generic;
using LeetCodeTony;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodeUnitTest;

[TestClass]
public class UnitTest_0021MergeTwoSortedLists
{
/*    [TestMethod]
    public void Test_1()
    {
        ListNode l1 = new ListNode(1, new ListNode(2, new ListNode(4, null)));
        ListNode l2 = new ListNode(1, new ListNode(3, new ListNode(4, null)));
        ListNode expected = new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(4, null))))));

        var result = new _0021MergeTwoSortedLists().MergeTwoLists(l1, l2);
        CollectionAssert.AreEqual(GetCollection(expected), GetCollection(result));
    }

    [TestMethod]
    public void Test_2()
    {
        ListNode l1 = new ListNode(-9, new ListNode(3, null));
        ListNode l2 = new ListNode(5, new ListNode(7, null));
        ListNode expected = new ListNode(-9, new ListNode(3, new ListNode(5, new ListNode(7,null))));

        var result = new _0021MergeTwoSortedLists().MergeTwoLists(l1, l2);
        CollectionAssert.AreEqual(GetCollection(expected), GetCollection(result));
    }    

    [TestMethod]
    public void Test_3()
    {
        ListNode l1 = new ListNode(-10, new ListNode(-10, new ListNode(-9, new ListNode(-4, new ListNode(1, null)))));
        ListNode l2 = new ListNode(-7, null);
        ListNode expected = new ListNode(-10, new ListNode(-10, new ListNode(-9, new ListNode(-7,new ListNode(-4, new ListNode(1, null))))));

        var result = new _0021MergeTwoSortedLists().MergeTwoLists(l1, l2);
        CollectionAssert.AreEqual(GetCollection(expected), GetCollection(result));
    }        

    public ICollection GetCollection(ListNode l)
    {

        List<int> r = new List<int>();

        if (l == null)
            return r;

        while (l.next != null)
        {
            r.Add(l.val);

            if (l.next != null)
                l = l.next;
        }

        if (l.val >= -100 && l.val <= 100)
            r.Add(l.val);



        r.ForEach(r => System.Console.WriteLine(r));

        return r;

    }*/
}