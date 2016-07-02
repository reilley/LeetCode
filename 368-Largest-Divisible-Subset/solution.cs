public class Solution {
    public IList<int> LargestDivisibleSubset(int[] nums) {
        var list = new LinkedList<int>();
        if(nums==null || nums.Length<=0) return list.ToList();
        
        Array.Sort(nums);
        int[] dp = new int[nums.Length];
        int[] lastPts = new int[nums.Length];
        int maxIndex = -1;
        int globalMax = -1;
        for(int i=0; i<nums.Length; i++){
            dp[i] = 1;
            lastPts[i] = -1;
            for(int j=0; j<i; j++){
                if(nums[i]%nums[j] ==0 && dp[j] +1 >dp[i]){
                    dp[i] = dp[j] +1;
                    lastPts[i] = j;
                }
            }
            if(dp[i] > globalMax){
                globalMax = dp[i];
                maxIndex = i;
            }
        }
        
        //form the list
        int k = maxIndex;
        while(k>=0){
            list.AddFirst(nums[k]);
            k = lastPts[k];
        }
        
        return list.ToList();
        
    }
}