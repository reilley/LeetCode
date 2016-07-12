public class Solution {
    public int numSquares(int n) {
        if(n<=0) return 0;
        if(n<=3) return n;
        int[] dp  = new int[n+1];
        List<Integer> list = new ArrayList<Integer>();
        //form square list
        int num = 1;
        int addition = 1;
        while(num <= n){
            list.add(num);
            dp[num] = 1;
            addition += 2;
            num += addition;
        }

        for(int i=1; i<=n; i++){
            for(int j : list){
                if(i+j > n) continue;
                dp[i+j] = dp[i+j] ==0 ? dp[i]+1 : Math.min(dp[i+j], dp[i]+1); 
            }
        }
        
        return dp[n];
    }
    
}