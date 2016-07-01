public class Solution {
    public int FindDuplicate(int[] nums) {
        if(nums==null || nums.Length<=1) return -1;
        int lo = 1, hi = nums.Length-1;
        while(lo<hi){
            int mid = lo + (hi-lo)/2;
            int cnt = nums.Where(x => x>=lo && x<=mid).Count();
            if(cnt > mid-lo+1) hi = mid;
            else lo = mid+1;
        }
        return lo;
    }
}