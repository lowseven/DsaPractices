using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesAndSolutions.Leetcode
{
    //https://leetcode.com/problems/binary-tree-inorder-traversal/description/
    public class BinaryTreeInorderTraversalProblem
    {
        List<int> l = new List<int>();
        public IList<int> InorderTraversal(TreeNode root)
        {
            if (root == null)
            {
                return l;
            }
            InorderTraversal(root.left);
            l.Add(root.val);
            InorderTraversal(root.right);

            return l;
            /* iteratively
              List<int> result = new List<int>();
             Stack<TreeNode> stack = new Stack<TreeNode>();

             while (root != null || stack.Count > 0)
             {
                 while (root != null)
                 {
                     stack.Push(root);
                     root = root.left;
                 }
                 root = stack.Pop();
                 result.Add(root.val);
                 root = root.right;
             }

             return result;
             */
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
