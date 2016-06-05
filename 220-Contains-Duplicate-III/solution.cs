public class Solution {
    public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t) {
        var dict = new Dictionary<long,int>();
        if(nums.Length==0 || k<=0 || t<0) return false;
        for(int i=0; i<nums.Length; i++){
            if(dict.Any(x => Math.Abs(x.Key-nums[i])<=t && Math.Abs(x.Value-i)<=k)) return true;
            dict[nums[i]] = i;
        }
        return false;
    }
}