public class Solution {
    private int[] _cache;
    public int MaxProfit(int[] prices) {
        if(prices==null || prices.Length<=1) return 0;
        var sells = new int[prices.Length];
        var buys = new int[prices.Length];
        buys[0] = -prices[0];
        for(int i=1; i<prices.Length; i++){
            buys[i] = Math.Max((i<=1 ? 0 : sells[i-2]) - prices[i], buys[i-1]);
            sells[i] = Math.Max(buys[i-1]+prices[i], sells[i-1]);
        }
        return sells[prices.Length-1];
    }
}