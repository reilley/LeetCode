public class NumMatrix {
    
    private int[,] _sums;
    public NumMatrix(int[,] matrix) {
        
        _sums = new int[matrix.GetLength(0)+1, matrix.GetLength(1)+1];

        for(int i=1; i<_sums.GetLength(0); i++){
            for(int j=1; j<_sums.GetLength(1); j++){
                _sums[i,j] = _sums[i-1, j] + _sums[i, j-1] - _sums[i-1, j-1] + matrix[i-1,j-1];
            }
        }
        
    }

    public int SumRegion(int row1, int col1, int row2, int col2) {
        if(row2>=_sums.GetLength(0) || col2>=_sums.GetLength(1)) return 0;
         return _sums[row2+1, col2+1] - _sums[row1, col2+1] - _sums[row2+1, col1] + _sums[row1, col1];
    }
}


// Your NumMatrix object will be instantiated and called as such:
// NumMatrix numMatrix = new NumMatrix(matrix);
// numMatrix.SumRegion(0, 1, 2, 3);
// numMatrix.SumRegion(1, 2, 3, 4);