using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllChallenge.ama
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val, TreeNode left, TreeNode right)
        {
            val = val;
            left = left;
            right = right;
        }
    }

    public class TreeTest
    {
        //leetcode 144
        public IList<int> PreorderTraversal(TreeNode root)
        {
            var results = new List<int>();

            //validation
            if (root == null) return results;

            results.Add(root.val);
            results.AddRange(PreorderTraversal(root.left));
            results.AddRange(PreorderTraversal(root.right));

            return results;
        }

        //leetcode 104
        public int MaxDepth(TreeNode root)
        {
            int result = 0;
            int current = 0;

            if (root == null) return result;

            int leftmax = MaxDepth(root.left);
            int rightMax = MaxDepth(root.right);

            result = Math.Max(leftmax, rightMax) + 1;

            return result;
        }

        //leetcode 515
        public IList<int> LargestValues(TreeNode root)
        {
            var results = new List<int>();

            if (root == null) return results;

            Queue<TreeNode> q = new Queue<TreeNode>();

            q.Enqueue(root);

            while(q.Any())
            {
                int sz = q.Count();

                int maxCur = int.MinValue;
                for (int i = 0; i < sz; i++)
                {
                    var cur = q.Dequeue();

                    maxCur = Math.Max(maxCur, cur.val);
                    if (cur.left != null)
                    {
                        q.Enqueue(cur.left);
                    }
                    if (cur.right != null)
                    {
                        q.Enqueue(cur.right);
                    }
                }

                results.Add(maxCur);
            }

            return results;
        }

        //leetcode 912
        public int[] QuickSort(int[] nums)
        {

            QQuickSort(nums, 0, nums.Length-1);

            return nums;

        }

        public void QQuickSort(int[] nums, int low, int high)
        {
            if (high > low)
            {
                var p = Qpartition(nums, low, high);

                QQuickSort(nums, low, p - 1);
                QQuickSort(nums, p + 1, high);
            }


        }

        public void QSwap(int[] arr, int i, int j)
        {
            var temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        public int Qpartition(int[] arr, int low, int high)
        {
            int pivot = arr[high];

            int i = low - 1;

            for(int j = low;j <= high - 1;j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    QSwap(arr, i, j);
                }
            }

            QSwap(arr, i + 1, high);
            return i + 1;
        }

        
    }
}
