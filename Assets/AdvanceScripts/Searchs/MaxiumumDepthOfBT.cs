using System;
using TreeEditor;
using UnityEngine;

public class MaxiumumDepthOfBT : MonoBehaviour
{
    /**
     * Definition for a binary tree node.
     * public class TreeNode {
     *     public int val;
     *     public TreeNode left;
     *     public TreeNode right;
     *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
     *         this.val = val;
     *         this.left = left;
     *         this.right = right;
     *     }
     * }
     
    public class Solution
    {
        public int MaxDepth(TreeNode root)
        {
            int branch;
            if (root == null) return 0;
            else
            {
                branch = Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1;
            }
            return branch;
        }
    }
    */
}
