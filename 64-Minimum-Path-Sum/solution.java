public class Solution {
    public int minPathSum(int[][] grid) {
        if (grid == null || grid.length == 0 || grid[0].length == 0) return 0;
        int m = grid.length;
        int n = grid[0].length;
        int[][] dp = new int[m+1][n+1];
        for (int i=0; i<=m; i++) {
            dp[i][0] = Integer.MAX_VALUE;
        }
        
        for (int j=1; j<=n; j++) {
                dp[0][j] = Integer.MAX_VALUE;
            }
        
        for (int i=1; i<=m; i++) {
            for (int j=1; j<=n; j++) {
                if(i==1 && j==1) {
                    dp[i][j] = grid[0][0];
                } else
                dp[i][j] = Math.min(dp[i-1][j], dp[i][j-1]) + grid[i-1][j-1];
            }
        }

        return dp[m][n];
    }
    
    private int minSum(int[][] grid, int x, int y, boolean[][] visited ) {
        if(x == grid.length-1 && y == grid[0].length -1) {
            visited[x][y] = true;
            return grid[x][y];
        }
            
        if(visited[x][y]) return grid[x][y];
        int right = Integer.MAX_VALUE;
        int down = Integer.MAX_VALUE;
        if(x < grid.length-1) {
            right = minSum(grid, x+1, y, visited);
        }
        
        if(y < grid[0].length-1) {
            down = minSum(grid, x, y+1, visited);
        }
        visited[x][y] = true;
        grid[x][y] = Math.min(right, down) + grid[x][y];
        return grid[x][y];
    }
}