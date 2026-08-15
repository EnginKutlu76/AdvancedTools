using TreeEditor;
using UnityEngine;

public class SortedArrayToBinarySearch : MonoBehaviour
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
     */

    //Solution 1//
/*    public class Solution1
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums.Length <= 0)
                return null;

            int mid = nums.Length / 2;
            var tree = new TreeNode(nums[mid]);
            tree.left = SortedArrayToBST(nums[..mid]);
            tree.right = SortedArrayToBST(nums[(mid + 1)..]);

            return tree;
        }
    }

    //Solution 2//

/*    public class Solution2
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            return Build(nums, 0, nums.Length - 1);
        }

        private TreeNode Build(int[] nums, int left, int right)
        {
            if (left > right)
                return null;

            int mid = (left + right) / 2;

            TreeNode root = new TreeNode(nums[mid]);

            root.left = Build(nums, left, mid - 1);
            root.right = Build(nums, mid + 1, right);

            return root;
        }
    }
*/
}
