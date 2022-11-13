using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{


 
 public class TreeNode {
     public int val;
     public TreeNode left;
     public TreeNode right;
     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
         this.val = val;
         this.left = left;
         this.right = right;
     }
}

    public class _98ValidateBinarySearchTree
    {
        public bool IsValidBST(TreeNode root)
        {

            if (root.left == null && root.right == null) { return true; }

            if (root.left != null && root.right == null)
            {
                return root.val > root.left.val && IsValidBST(root.left) && AllKidsLess(root.left, true, root.val);
            }

            if (root.right != null && root.left == null)
            {
                return root.val < root.right.val && IsValidBST(root.right) && AllKidsLess(root.right, false, root.val);
            }

            if (root.left != null && root.right != null)
            {
                return root.val > root.left.val && root.val < root.right.val 
                    && IsValidBST(root.left) 
                    && IsValidBST(root.right)
                    && AllKidsLess(root.left, true, root.val)
                    && AllKidsLess(root.right, false, root.val);
            }

            return false;

            bool AllKidsLess(TreeNode node, bool less, int v)
            {
                var kids = AllKids(node);                
                return less ? !kids.Any(k => k >= v) : !kids.Any(k => k <= v);
            }

            List<int> AllKids(TreeNode node)
            {
                if (node.left ==null && node.right == null)
                {
                    return new List<int>() { node.val };
                } else if (node.left != null && node.right == null)
                {
                    return AllKids(node.left);
                } else if (node.right != null && node.left == null)
                {
                    return AllKids(node.right);
                } else
                {
                    var x = AllKids(node.left);
                    x.AddRange(AllKids(node.right));
                    return x;
                }

                return new List<int>();
            }
        }     

        bool IsValidBST(TreeNode root, TreeNode min, TreeNode max) 
        {
            if(root==null) return true;
            if(min!=null &&root.val <=min.val) return false;
            if(max!=null && root.val>=max.val)return false;

            return IsValidBST(root.left,min,root) && IsValidBST(root.right,root,max);
        }

    }
}
