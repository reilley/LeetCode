public class Solution {
    public int MinPathSum(int[,] grid) {
        if(grid==null || grid.GetLength(0)==0) return 0;
        int m = grid.GetLength(0);
        int n = grid.GetLength(1);
        
        var table = new int[n+1];
        for(int i=0; i <=n; i++){
            table[i] = int.MaxValue;
        }
        table[1] = 0;
        for(int i=0; i<m; i++){
            for(int j=0; j<n; j++){
                table[j+1] = Math.Min(table[j], table[j+1]) + grid[i,j];
            }
        }
        return table[n];
    }
}