public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        if(nums==null || nums.Length ==0) return false;
        var dict = new Dictionary<int, int>();
        for(int i=0; i<nums.Length; i++){
            if(!dict.ContainsKey(nums[i])){
                dict[nums[i]] = i;
            } else {
                if(i-dict[nums[i]] <=k)
                    return true;
                else 
                    dict[nums[i]] = i;
            }
        }
        return false;
    }
}