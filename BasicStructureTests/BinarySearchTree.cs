using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStructureTests;
public class ListNode
{
    public int val;
    public ListNode left;
    public ListNode right;
    public ListNode(int val = 0, ListNode left = null, ListNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Tree
{
    public ListNode Root { get; set; }

    public void Insert(int val)
    {
        if (Root == null)
            Root = new ListNode(val);
        else
        {
            this.Insert(val, Root);
        }
    }

    private ListNode Insert(int value, ListNode root)
    {
        if (root == null)
            return new ListNode(value);

        if (value < root.val)
        {
            root.left = Insert(value, root.left);
        }
        else if (value > root.val)
        {
            root.right = Insert(value, root.right);
        }

        return root;
    }

    public int FindMin()
    {
        var node = FindMin(Root);
        return node == null ? -1 : node.val;
    }

    public int FindMax()
    {
        var node = FindMax(Root);
        return node == null ? -1 : node.val;
    }

    public ListNode FindMin(ListNode root)
    {
        if (root == null)
            return root;
        while (root != null && root.left != null)
            root = root.left;

        return root!;
    }

    public ListNode FindMax(ListNode root)
    {
        if (root == null)
            return root;
        while (root != null && root.right != null)
            root = root.right;

        return root!;
    }

    public int Height() =>
        Height(Root, 0);

    private int Height(ListNode root, int h)
    {
        if (root == null)
            return h;

        return Math.Max(Height(root.left, h + 1), Height(root.right, h + 1));
    }

    public void Remove(int value) =>
        Remove(Root, value);

    private ListNode Remove(ListNode root, int value)
    {
        if (root == null)
            return null;
        //traverse the tree
        if (value > root.val)
            root.right = Remove(root.right, value);
        else if (value < root.val)
            root.left = Remove(root.left, value);
        //worst case the current RootNode has 2 childs
        else
        {
            if (root.left == null)
                return root.right;//null
            else if (root.right == null)
                return root.left;//null
            else
            {
                /* here i already checked that the left side is not where is "value"
                  if (value > root.val)
                        root.right = Remove(root.right, value);
                    else if (value < root.val)
                        root.left = Remove(root.left, value);
                 */
                var minNode = this.FindMin(root.right);
                root.val = minNode.val;
                root.right = this.Remove(root.right, minNode.val);
            }
        }
        return root;
    }

    //An inorder traversal will recurively visit all the nodes in the left subtree, 
    //then visit the parent node and finally visit all the nodes in the right subtree.
    //In this case, "visit" could mean anything from printing the node to performing some operation on it.
    public void TraverseInOrder() =>
        TraverseInOrder(Root);

    private void TraverseInOrder(ListNode root)
    {
        if (root == null) return;

        TraverseInOrder(root.left);
        Console.WriteLine(root.val);
        TraverseInOrder(root.right);
    }

    //A postorder traversal will visit the left subtree, then the right subtree and finally the parent node last.
    public void TraversePostOrder() => TraversePostOrder(Root);
    private void TraversePostOrder(ListNode root)
    {
        if (root == null) return;

        TraverseInOrder(root.left);
        TraverseInOrder(root.right);
        Console.WriteLine(root.val);
    }

    //preorder traversal will visit the parent node first, then visit the left subtree and finally visit the right subtree.
    public void TraversePreOrder() => TraversePreOrder(Root);
    private void TraversePreOrder(ListNode root)
    {
        if (root == null) return;

        Console.WriteLine(root.val);
        TraverseInOrder(root.left);
        TraverseInOrder(root.right);
    }

}
