namespace DefaultNamespace;

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
public class Solution {
    public bool IsValidBST(TreeNode root) {
        return IsValidBSTHelper(root, null, null);
    }

    private bool IsValidBSTHelper(TreeNode node, int? minVal, int? maxVal) {
        if (node == null) return true;
        if ((minVal != null && node.val <= minVal) || (maxVal != null && node.val >= maxVal)) {
            return false;
        }
        return IsValidBSTHelper(node.left, minVal, node.val) && IsValidBSTHelper(node.right, node.val, maxVal);
    }
}