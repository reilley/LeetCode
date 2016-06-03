public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        if(nums==null || nums.Length==0) return false;
        var set = new HashSet<int>();
        foreach(int num in nums){
            if(set.Contains(num)){
                return true;
            }
            else
                set.Add(num);
        }
        return false;
    }
}