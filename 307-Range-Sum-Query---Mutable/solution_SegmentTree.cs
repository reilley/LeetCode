public class NumArray {
    private class SegmentTreeNode{
        public int start, end;
        public int sum;
        public SegmentTreeNode left, right;
        public SegmentTreeNode(int s, int e, int val){
            start = s;
            end = e;
            sum = val;
            left = null;
            right = null;
        }
    }
    
    private SegmentTreeNode root;
    public NumArray(int[] nums) {
        root = BuildTree(nums, 0, nums.Length-1);
    }
    
    private SegmentTreeNode  BuildTree(int[] nums, int s, int e){
        if(e<s) return null;
        if(s==e) return new SegmentTreeNode(s,e, nums[s]);
        int mid = s + (e-s)/2;
        
        var left = BuildTree(nums, s, mid);
        var right  = BuildTree(nums, mid+1, e);
        var node = new SegmentTreeNode(s, e, (left==null?0:left.sum) +(right==null?0:right.sum));
        node.left = left;
        node.right = right;
        return node;
    }
    
    private int UpdateTree(int index, int val, SegmentTreeNode root){
        int diff = 0;
        if(root.start==root.end && index==root.start) {
            diff = val - root.sum;
            root.sum = val;
            return diff;
        }
        
        int mid = start + (end-start)/2;
        diff = UpdateTree(index, val, index > mid ? root.right : root.left);
        root.sum += diff;
        return diff;
    }

    public void Update(int i, int val) {
        if(i>=array.Length) return;
        UpdateTree(i, val, root);
    }

    public int SumRange(int i, int j) {
        return SumRange(root, i, j);
    }
    
    private int SumRange(SegmentTreeNode root, int i, int j){
        if(i==start && j==end) return root.sum;
        int mid = root.start + (root.end-root.start)/2;
        if(i>mid) 
            return SumRange(root.right, i, j);
        else if(j<=mid){
            return SumRange(root.left, i, j);
        } else{
            return SumRange(root.left, i, mid) + SumRange(root.right, mid+1, j);
        }
    }

}


// Your NumArray object will be instantiated and called as such:
// NumArray numArray = new NumArray(nums);
// numArray.SumRange(0, 1);
// numArray.Update(1, 10);
// numArray.SumRange(1, 2);