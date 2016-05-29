public class Solution {
    public bool SearchMatrix(int[,] matrix, int target) {
        if(matrix==null) return false;
        int m = matrix.GetLength(0);
        int n = matrix.GetLength(1);
        
        if(m==0 || n==0) return false;
        //treat the matrix as binary tree which root is up-right corner
        int i=0; 
        int j=n-1;
        while(i<m && j>=0){
            if(target>matrix[i,j]){
                i++;
            }else if(target<matrix[i,j]){
                j--;
            } else{
                return true;
            }
        }
        return false;
    }
    
    
}