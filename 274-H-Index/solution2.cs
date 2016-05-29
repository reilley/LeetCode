public class Solution {
    public int HIndex(int[] citations) {
        if(citations==null || citations.Length==0) return 0;
        int n = citations.Length;
        int[] buckets = new int[n+1];
        for(int i=0; i<n; i++){
            if(citations[i]>=n)
                buckets[n]++;
            else
                buckets[citations[i]]++;
        }
        
        int count =0;
        for(int i=n; i>=0; i--){
            count += buckets[i];
            if(count>=i) return i;
        }
        
        return 0;
    }
}