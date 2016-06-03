public class NumArray {
    private int[] sums;
    public NumArray(int[] nums) {
        if(nums==null || nums.Length==0) return;
        sums = new int[nums.Length];
        sums[0] = nums[0];
        for(int i=1; i<nums.Length; i++){
            sums[i] = sums[i-1] + nums[i];
        }
    }

    public int SumRange(int i, int j) {
        return i==0 ? sums[j] : sums[j] - sums[i-1];
    }
}


// Your NumArray object will be instantiated and called as such:
// NumArray numArray = new NumArray(nums);
// numArray.SumRange(0, 1);
// numArray.SumRange(1, 2);