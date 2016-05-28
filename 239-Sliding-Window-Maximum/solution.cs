public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        if(k<=1 || nums.Length==0) return nums;
        
        //use two-passes number arrays
        int[] left = new int[nums.Length];
        int[] right = new int[nums.Length];
        int i=0; 
        while(i<nums.Length){
            left[i] = nums[i];
            for(int j=1; j<k && i+j<nums.Length; j++){
                left[i+j] = Math.Max(left[i+j-1], nums[i+j]);
            }
            i += k;
        }
        
        i=0; 
        while(i<nums.Length){
            int m = Math.Min(nums.Length-1, i+k-1);
            right[m] = nums[m];
            for(int j=1; m-j>=i; j++){
                right[m-j] = Math.Max(right[m-j+1], nums[m-j]);
            }
            i += k;
        }
        
        int[] results = new int[nums.Length-k+1];
        for(i=0; i<=nums.Length-k; i++){
            results[i] = Math.Max(left[i+k-1], right[i]);
        }
        return results;
    }
}