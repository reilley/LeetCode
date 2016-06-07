public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var arr = new int[nums.Length];
        int n = nums.Length;
        for(int i=0; i<n; i++){
            arr[i] = 1;
        }
        int s = 1, e=1;
        for(int i=0; i<nums.Length; i++){
            arr[i] *= s;
            s *= nums[i];
            arr[n-i-1] *= e;
            e *= nums[n-i-1];
        }
        return arr;
    }
}