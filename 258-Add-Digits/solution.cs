public class Solution {
    public int AddDigits(int num) {
        while(num>=10){
            int n = 0;
            while(num>0){
                n += num %10;
                num /= 10;
            }
            num = n;
        }
        
        return num;
    }
}