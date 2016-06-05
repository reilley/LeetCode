public class NumArray {
    private int[] array;
    public NumArray(int[] nums) {
        array = new int[nums.Length+1];
        if(nums.Length==0) return;
        array[0] = nums[0];
        for(int i=0; i<nums.Length;i++){
            array[i+1] = array[i] + nums[i];
        }
    }

    public void Update(int i, int val) {
        if(i>=array.Length) return;
        int diff = val - nums[i];
        for(int j=i+1; j<nums.Length; j++){
            array[j] += diff;
        }
        nums[i] = val;
    }

    public int SumRange(int i, int j) {
        return array[j+1]-array[i];
    }
}


// Your NumArray object will be instantiated and called as such:
// NumArray numArray = new NumArray(nums);
// numArray.SumRange(0, 1);
// numArray.Update(1, 10);
// numArray.SumRange(1, 2);