public class Solution {
    public int RangeBitwiseAnd(int m, int n) {
        if(m==0) return 0;
        if(m==n) return m;
        int h = m^n;
        int count = 0;
        //h = ~h;
        while(h!=0){
            h = h >> 1;
            count++;
        }
        n = n >> count;
        n = n << count;
        return n;
    }
}