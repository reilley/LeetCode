public class NumArray {
    private int[] sums;
    public NumArray(int[] nums) {
        sums = new int[nums.Length+1];
        for(int i=0; i<nums.Length; i++){
            sums[i+1] = sums[i] + nums[i];
        }
    }

    public int SumRange(int i, int j) {
        return sums[j+1] - sums[i];
    }
}


// Your NumArray object will be instantiated and called as such:
// NumArray numArray = new NumArray(nums);
// numArray.SumRange(0, 1);
// numArray.SumRange(1, 2);