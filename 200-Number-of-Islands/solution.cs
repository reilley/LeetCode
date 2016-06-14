public class Solution {
    public int NumIslands(char[,] grid) {
        if(grid==null || grid.GetLength(0)==0) return 0;
        int total = 0;
        for(int i=0; i<grid.GetLength(0); i++){
            for(int j=0; j<grid.GetLength(1); j++){
                if(helper(grid,i,j)) total++;
            }
        }
        return total;
    }
    
    private bool helper(char[,] grid, int i, int j){
        if(i<0 || j<0 || i>=grid.GetLength(0) || j>=grid.GetLength(1)) return false;
        if(grid[i,j]=='0' || grid[i,j]=='x') return false;
        grid[i,j]='x';
        helper(grid, i+1, j);
        helper(grid, i, j+1);
        helper(grid, i-1, j);
        helper(grid, i, j-1);
        return true;
    }
}