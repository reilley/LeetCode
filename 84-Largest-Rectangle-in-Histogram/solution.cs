public class Solution {
    public int LargestRectangleArea(int[] heights) {
        if(heights==null || heights.Length==0) return 0;
        
        int max = 0;
        int i = 0;
        while(i<heights.Length){
            int area = heights[i];
            int j = i-1;
            while(j>=0 && heights[j]>=heights[i]){
                area += heights[i];
                j--;
            }
            j = i+1;
            while(j<heights.Length && heights[j]==heights[i]){
                area += heights[i];
                j++;
            }
            i = j-1;
            while(j<heights.Length && heights[j]>heights[i]){
                area += heights[i];
                j++;
            }
            max = Math.Max(max, area);
            i++;
        }
        return max;
    }
}