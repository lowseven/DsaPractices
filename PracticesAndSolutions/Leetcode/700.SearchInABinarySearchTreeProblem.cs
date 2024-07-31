using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesAndSolutions.Leetcode
{
    internal class SearchInABinarySearchTreeProblem
    {
        //https://leetcode.com/problems/search-in-a-binary-search-tree/description/
        public TreeNode SearchBST(TreeNode root, int val)
        {
            if (root == null)
                return null;
            if (val < root.val)
                return SearchBST(root.left, val);
            else if (val > root.val)
                return SearchBST(root.right, val);
            else
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
