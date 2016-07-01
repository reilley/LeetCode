public class Solution {
    public int FindDuplicate(int[] nums) {
        if(nums==null || nums.Length<=1) return 0;
        int slow = 0;
        int fast = 0;
        do{
            slow = nums[slow];
            fast = nums[nums[fast]];
            if(slow!=0 && nums[slow]==nums[0] || fast != 0 && nums[fast]==nums[0]) 
                return nums[0];
        }while(slow != fast);
        
        int res = 0;
        slow = 0;
        do{
            slow = nums[slow];
            fast = nums[fast];
        } while(slow != fast);
        return slow;
    }
}