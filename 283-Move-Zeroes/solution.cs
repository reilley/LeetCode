public class Solution {
    public void MoveZeroes(int[] nums) {
        if(nums==null || nums.Length<=1) return;
        int i=0; 
        int j = 0;
        while(i<nums.Length && j<nums.Length){
            if(nums[i]!=0 && nums[j]!=0){
                i++;
                j++;
            } else if(nums[j]==0){
                j++;
            } else {
                nums[i++] = nums[j];
                nums[j++] = 0;
            }
        }
        
    }
}