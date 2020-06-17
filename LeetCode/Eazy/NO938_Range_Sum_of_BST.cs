using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Runtime.InteropServices;
using System.Text;

namespace LeetCode.Eazy
{
    /**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
    public class NO938_Range_Sum_of_BST
    {
        public int RangeSumBST(TreeNode root, int L, int R)
        {
            return RecursiveBST(root, L, R);
        }

        public int RecursiveBST(TreeNode root, int l, int r, int resultSun = 0)
        {
            if (root != null)
            {
                if (root.val >= l && root.val <= r)
                {
                    resultSun += root.val;
                }

                if (root.left != null) resultSun = RecursiveBST(root.left, l, r, resultSun);
                if (root.right != null) resultSun = RecursiveBST(root.right, l, r, resultSun);
            }
            return resultSun;
        }

    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x)
        {
            val = x;
        }
    }
}
