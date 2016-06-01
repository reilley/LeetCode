public class Solution {
    public int AddDigits(int num) {
        //digit root formula
        return num==0 ? 0: num%9==0 ? 9 : num %9;
        
    }
}