using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesAndSolutions.Leetcode
{
    public class KthSmallestElementInABSTProblem
    {
        public int KthSmallest(TreeNode root, int k)
        {
            Traverse(root);
            return l[k - 1];
        }

        List<int> l = new List<int>();
        public TreeNode Traverse(TreeNode root)
        {
            /* without recursion and list
               var s = new Stack<TreeNode>();
                var l = new List<int>();//this can be removed using a counter...

                var cur = root;
                while(cur != null || s.Count > 0) {
                    while (cur != null) { 
                        s.Push(cur);
                        cur = cur.left;
                    }
                    var node = s.Pop();
                    l.Add(node.val);
                    cur = node.right;
                }

                return l[k - 1];
             */
            if (root == null)
                return root;

            Traverse(root.left);
            l.Add(root.val);
            Traverse(root.right);

            return root;
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
    }
}
