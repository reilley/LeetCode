public class Solution {
    public int minPathSum(int[][] grid) {
        if (grid == null || grid.length == 0 || grid[0].length == 0) return 0;
        boolean[][] visited = new boolean[grid.length][grid[0].length];
        return minSum(grid, 0, 0, visited);
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