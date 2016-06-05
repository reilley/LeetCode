public class NumArray {
    private int[] array;
    public NumArray(int[] nums) {
        array = new int[nums.Length];
        if(nums.Length==0) return;
        helper(nums, 0, nums.Length-1);
    }
    
    private int helper(int[] nums, int left, int right){
        if(left>right) return 0;
        int mid = left + (right-left)/2;
        int l = helper(nums, left, mid-1);
        int r = helper(nums, mid+1, right);
        array[mid] = nums[mid] + l + r;
        return array[mid];
    }

    public void Update(int i, int val) {
        if(i>=array.Length) return;
        int diff = val - SumRange(i,i);
        Update(i, val, 0, array.Length-1);
    }

    public int SumRange(int i, int j) {
        return SumRange(i,j,0,array.Length-1);
    }
    
    private int SumRange(int i, int j, int start, int end){
        if(end<start) return 0;
        
        int mid = start + (end -start)/2;
        if(i==start && j==end){
            return array[mid];
        }
        if(j<mid){
            return SumRange(i,j,start, mid-1) - GetValue(mid+1, end);
        } else if(i>mid){
            return SumRange(i,j, mid+1, end) - GetValue(start, mid-1) ;
        } else{
            return SumRange(i,j, start, mid-1) + SumRange(i,j,mid+1, end) + GetMidValue(start, end);
        }
        
    }
    
    private int Update(int i, int val, int start, int end){
        if(start>end) return 0;
        int mid = start + (end -start)/2;
        int diff = 0;
        if(mid==i){
            int midValue = array[mid] - GetValue(mid+1, end) - GetValue(start, mid-1);
            diff = val - midValue;
        } else if(i<mid){
            diff = Update(i, val, start, mid-1);
        } else{
            diff = Update(i, val, mid+1, end);
        }
        array[mid] += diff;
        return diff;
    }
    
    private int GetValue(int start, int end){
        if(end<start) return 0;
        int mid = start + (end-start)/2;
        return array[mid];
    }
    
    private int GetMidValue(int start, int end){
        if(start>end) return 0;
        int mid = start + (end -start)/2;
        return array[mid] - GetValue(mid+1, end) - GetValue(start, mid-1);
    }
}


// Your NumArray object will be instantiated and called as such:
// NumArray numArray = new NumArray(nums);
// numArray.SumRange(0, 1);
// numArray.Update(1, 10);
// numArray.SumRange(1, 2);