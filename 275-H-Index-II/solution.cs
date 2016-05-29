public class Solution {
    public int HIndex(int[] citations) {
        if(citations==null || citations.Length==0) return 0;
        int n = citations.Length;
        int start = 0;
        int end = n-1;
        while(start<=end){
            int mid = start + (end-start)/2;
            if(citations[mid]==n-mid) return n-mid;
            if(citations[mid] < n-mid) 
                start = mid+1;
            else
                end = mid -1;
        }
        
        return n-end-1;
    }
}