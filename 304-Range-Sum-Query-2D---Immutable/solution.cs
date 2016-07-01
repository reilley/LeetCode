public class NumMatrix {
    
    private int[,] _sums;
    public NumMatrix(int[,] matrix) {
        _sums = new int[matrix.GetLength(0), matrix.GetLength(1)];
        
        for(int i=0; i<matrix.GetLength(0); i++){
            for(int j=0; j<matrix.GetLength(1); j++){
                if(i==0 && j==0){
                    _sums[i,j] = matrix[i,j];
                } else if(i==0){
                    _sums[i,j] = _sum[i, j-1] + matrix[i,j];
                } else if(j==0){
                    _sums[i,j] = _sum[i-1, j] + matrix[i,j];
                } else
                _sums[i,j] = _sum[i-1, j] + _sum[i, j-1] + matrix[i,j];
            }
        }
        
    }

    public int SumRegion(int row1, int col1, int row2, int col2) {
        int res = _sums[row2,col2];
        if(row1>0){
            res -= _sums[row1-1, col2];
        }
        if(col1>0){
            res -= _sums[row2, col1-1];
        }
        
        if(row1>0 && col1>0){
            res += _sums[row1-1, col1-1];
        }
        return res;
    }
}


// Your NumMatrix object will be instantiated and called as such:
// NumMatrix numMatrix = new NumMatrix(matrix);
// numMatrix.SumRegion(0, 1, 2, 3);
// numMatrix.SumRegion(1, 2, 3, 4);