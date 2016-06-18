public class Solution {
    public int RangeBitwiseAnd(int m, int n) {
        if(m==0) return 0;
        if(m==n) return m;
        long result = m;
        for(long i=m+1; i<=n; i++){
            result &= i;
            if(result==0) return 0;
        }
        return Convert.ToInt32(result);
    }
}