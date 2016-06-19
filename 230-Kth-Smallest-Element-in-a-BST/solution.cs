/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public int KthSmallest(TreeNode root, int k) {
        
        //convert tree node into array with in-order
        var list = new List<TreeNode>();
        var stack = new Stack<TreeNode>();
        stack.Push(root);
        while(stack.Count>0){
            var node = stack.Pop();
            if(node.right != null){
                stack.Push(node.right);
                node.right = null;
            }
            if(node.left==null){
                list.Add(node);
            } else{
                stack.Push(node);
                stack.Push(node.left);
                node.left = null;
            }
        }
        
        return list[k-1].val;
    }
}