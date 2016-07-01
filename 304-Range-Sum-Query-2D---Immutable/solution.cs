public class NumMatrix {
    
    private int[,] _sums;
    public NumMatrix(int[,] matrix) {
        
        _sums = new int[matrix.GetLength(0), matrix.GetLength(1)];

        for(int i=0; i<matrix.GetLength(0); i++){
            _sums[i,0] = matrix[i,0];
        }
        for(int i=0; i<matrix.GetLength(0); i++){
            for(int j=1; j<matrix.GetLength(1); j++){
                _sums[i,j] = _sums[i, j-1] + matrix[i,j];
            }
        }
        
    }

    public int SumRegion(int row1, int col1, int row2, int col2) {
        if(row2>=_sums.GetLength(0) || col2>=_sums.GetLength(1)) return 0;
        int res = 0;
        for(int i=row1; i<=row2; i++){
            res += _sums[i, col2];
            if(col1>0)
                res -= _sums[i, col1-1];
        }
        return res;
    }
}


// Your NumMatrix object will be instantiated and called as such:
// NumMatrix numMatrix = new NumMatrix(matrix);
// numMatrix.SumRegion(0, 1, 2, 3);
// numMatrix.SumRegion(1, 2, 3, 4);