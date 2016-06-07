public class Solution {
    public int[] SingleNumber(int[] nums) {
        int k = nums[0];
        for(int i=1; i<nums.Length; i++){
            k = k^nums[i];
        }
        
        int bit = k & ~(k-1);
        int[] results = new int[2];
        foreach(int num in nums){
            if((num & bit)==0){
                results[0] ^= num;
            } else {
                results[1] ^= num;
            }
        }
        
        return results;
    }
}