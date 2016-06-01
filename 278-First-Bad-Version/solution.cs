/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        if(IsBadVersion(1)) return 1;
        //binary search
        int left = 1;
        int right = n;
        while(left<=right){
            int mid = left + (right-left)/2;
            if(IsBadVersion(mid) && !IsBadVersion(mid-1)) return mid;
            if(!IsBadVersion(mid)) left = mid+1;
            else right = mid -1;
        }
        return 0;
    }

}