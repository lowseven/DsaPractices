using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesAndSolutions.Leetcode
{
    //https://leetcode.com/problems/delete-node-in-a-bst/description/
    public class DeleteNodeInABSTProblem
    {
        public TreeNode DeleteNode(TreeNode root, int key)
        {
            if (root == null)
                return root;

            if (key > root.val)
                root.right = DeleteNode(root.right, key);
            else if (key < root.val)
                root.left = DeleteNode(root.left, key);
            else
            {
                if (root.left == null)
                    return root.right;
                else if (root.right == null)
                    return root.left;
                else
                {
                    root.val = FindMin(root.right).val;
                    root.right = DeleteNode(root.right, root.val);
                }

            }

            return root;
        }

        private TreeNode FindMin(TreeNode node)
        {
            if (node == null)
                return node;
            while (node != null && node.left != null)
                node = node.left;

            return node;
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
