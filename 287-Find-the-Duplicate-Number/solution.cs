public class Solution {
    public int FindDuplicate(int[] nums) {
        if(nums==null || nums.Length<=1) return 0;
        int slow = nums[0];
        int fast = nums[nums[0]];
        while(slow != fast){
            slow = nums[slow];
            fast = nums[nums[fast]];
        };
        
        int res = 0;
        slow = 0;
        do{
            slow = nums[slow];
            fast = nums[fast];
        } while(slow != fast);
        return slow;
    }
}