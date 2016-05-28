public class Solution {
    public bool SearchMatrix(int[,] matrix, int target) {
        int m = matrix.GetLength(0);
        int n = matrix.GetLength(1);
        
        if(m==0 || n==0) return false;
        return Search(matrix, target, 0,0,m-1, n-1);
    }
    
    private bool Search(int[,] matrix, int target, int up, int left, int down, int right){
        if(up>down || left>right || up<0 || down>=matrix.GetLength(0) || left<0 || right>=matrix.GetLength(1)) return false;
        if(target<matrix[up,left] || target>matrix[down,right]) return false;
        if(target==matrix[up,left] || target==matrix[down,right]) return true;
        
        int midRow = up + (down-up)/2;
        int midCol = left + (right-left)/2;
        int midVal = matrix[midRow, midCol];
        if(midVal==target) return true;
        if(target<midVal){
            bool upleft = Search(matrix, target, up, left, midRow, midCol-1);
            if(upleft) return true;
            bool upright = Search(matrix, target, up, midCol, midRow-1, right);
            if(upright) return true;
            bool downleft = Search(matrix, target, midRow+1, left, down, midCol-1);
            if(downleft) return true;
            
        } else{
            bool downright = Search(matrix, target, midRow+1, midCol+1, down, right);
            if(downright) return true;
            bool upright = Search(matrix, target, up, midCol+1, midRow, right);
            if(upright) return true;
            bool downleft = Search(matrix, target, midRow+1, left, down, midCol);
            if(downleft) return true;
        }
        return false;
    }
}