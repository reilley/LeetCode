public class Solution {
    public int HIndex(int[] citations) {
        if(citations==null || citations.Length==0) return 0;
        Array.Sort(citations, (a,b) => b.CompareTo(a)); //sort array in desceding order
        int max = 0;
        for(int i=0; i<citations.Length; i++){
            max = Math.Max(max, Math.Min(citations[i], i+1));
        }
        return max;
    }
}