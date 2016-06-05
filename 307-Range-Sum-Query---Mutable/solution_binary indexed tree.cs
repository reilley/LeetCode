public class NumArray {
    private int[] array;
    private int[] BITree;
    public NumArray(int[] nums) {
        array = new int[nums.Length];
        BITree = new int[nums.Length+1];
        for(int i=0; i<nums.Length; i++){
            array[i] = nums[i];
            UpdateTree(i, nums[i]);
        }
    }
    
    private void UpdateTree(int index, int val){
        index += 1;
        while(index < BITree.Length){
            BITree[index] += val;
            index += index & (-index);
        }
    }

    public void Update(int i, int val) {
        if(i>=array.Length) return;
        int diff = val - array[i];
        UpdateTree(i, diff);
    }

    public int SumRange(int i, int j) {
        return Sum(j) - Sum(i-1);
    }
    
    private int Sum(int index){
        if(index==0) return 0;
        index += 1;
        int sum = 0;
        while(index > 0){
            sum += BITree[index];
            index -= index & (-index);
        }
    }

}


// Your NumArray object will be instantiated and called as such:
// NumArray numArray = new NumArray(nums);
// numArray.SumRange(0, 1);
// numArray.Update(1, 10);
// numArray.SumRange(1, 2);