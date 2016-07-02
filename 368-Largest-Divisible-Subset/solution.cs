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
            int max = 1;
            int lastIndex = -1;
            for(int j=0; j<i; j++){
                if(nums[i]%nums[j] ==0 && dp[j] +1 >max){
                    max = dp[j] +1;
                    lastIndex = j;
                }
            }
            dp[i] = max;
            lastPts[i] = lastIndex;
            if(max > globalMax){
                globalMax = max;
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