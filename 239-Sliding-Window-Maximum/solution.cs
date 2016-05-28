public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        if(k<=1 || nums.Length==0) return nums;
        
        //use two-passes number arrays
        int[] left = new int[nums.Length];
        left[0] = nums[0];
        int[] right = new int[nums.Length];
        right[nums.Length-1] = nums[nums.Length-1];
        for(int i=1; i<nums.Length; i++){
            left[i] = (i%k==0)? nums[i] : Math.Max(left[i-1], nums[i]);
            int j = nums.Length - i -1;
            right[j] = (j%k==k-1)? nums[j] : Math.Max(right[j+1], nums[j]);
        }

        
        int[] results = new int[nums.Length-k+1];
        for(int i=0; i<=nums.Length-k; i++){
            results[i] = Math.Max(left[i+k-1], right[i]);
        }
        return results;
    }
}