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
    public IList<string> BinaryTreePaths(TreeNode root) {
        var list = new List<string>();
        if(root==null) return list;
        GetPath(root, list, root.val.ToString());
        return list;
    }
    
    private void GetPath(TreeNode root, List<string> list, string str){
        if(root==null) return;
        if(root.left==null && root.right==null){
            list.Add(str);
            return;
        }
        if(root.left != null)
            GetPath(root.left, list, str+"->"+root.left.val);
        if(root.right!=null)
            GetPath(root.right, list, str+"->"+root.right.val);
        
    }
}