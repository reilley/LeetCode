public class Solution {
    public boolean isPerfectSquare(int num) {
        if(num<1) return false;
        if(num==1) return true;
        int left = 2, right = num-1;
        
        while(left <= right){
            int mid = left + (right-left)/2;
            if(mid * mid == num)
                return true;
            else if(mid*mid > num){
                right = mid - 1;
            } else{
                left = mid +1;
            }
        }
        
        return false;
    }
}