namespace ClassLibrary1
{

    using System.Linq;

    public interface NestedInteger
    {
        // @return true if this NestedInteger holds a single integer, rather than a nested list.
        bool IsInteger();
        // @return the single integer that this NestedInteger holds, if it holds a single integer
        // Return null if this NestedInteger holds a nested list
        int GetInteger();
        // @return the nested list that this NestedInteger holds, if it holds a nested list
        // Return null if this NestedInteger holds a single integer
        IList<NestedInteger> GetList();
    }

    public class NestedIterator
    {

        private IEnumerator<int> it;
        public NestedIterator(IList<NestedInteger> nestedList)
        {
            List<int> result = new List<int>();
            foreach (var item in nestedList)
            {
                Traverse(item, result);
            }
            this.it = result.GetEnumerator();
        }

        public bool HasNext()
        {
            return it.MoveNext();
        }

        public int Next()
        {
            return it.Current;
        }

        private void Traverse(NestedInteger item, IList<int> result)
        {
            if (item.IsInteger())
            {
                result.Add(item.GetInteger());
                return;
            }
            else
            {
                foreach (var g in item.GetList())
                {
                    Traverse(g, result);
                }
            }
        }

        // private IList<NestedInteger> list;

        // public NestedIterator(IList<NestedInteger> nestedList)
        // {
        //     list = new List<NestedInteger>(nestedList);            
        // }
        // public int Next()
        // {
        //     var r = list.First().GetInteger();
        //     list.RemoveAt(0);
        //     return r;
        // }
        // public bool HasNext()
        // {
        //     while(list.Count>0 && !list.First().IsInteger())
        //     {
        //         var r = list.First().GetList();
        //         list.RemoveAt(0);
                

        //         for (int i = r.Count -1; i >=0; i--)
        //         {
        //             list.Insert(0,r[i]);
        //         } 
        //     }
        //     return list.Count > 0;
        // }
    }
}