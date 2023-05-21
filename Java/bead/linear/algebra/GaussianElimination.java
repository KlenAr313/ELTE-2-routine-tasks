package linear.algebra;

public class GaussianElimination{
    private int rows;

    public int getRows(){
        return rows;
    }

    private int cols;

    public int getCols(){
        return cols;
    }

    private double[][] matrix;

    public double[][] getMatrix(){
        double[][] newMatrix = new double[rows][cols];
        for(int i = 0; i < rows; i++){
            double[] row = this.matrix[i];
            System.arraycopy(row, 0, newMatrix[i], 0, cols);
        }

        return newMatrix;
    }

    public void setMatrix(double[][] matrix){
        try{
            checkMatrixDimensions(matrix);
            this.matrix = new double[rows][cols];
            for(int i = 0; i < rows; i++){
                double[] row = matrix[i];
                System.arraycopy(row, 0, this.matrix[i], 0, cols);
            }
        } catch (Exception e){
            System.err.println(e.toString());
            System.err.println(e.getMessage());
        }
        
    }

    private static char[] abc = {'x','y','z','a','b','c','d','e','f','g','h'}; // I hope it's enough

    public GaussianElimination(int rows, int cols, double[][] matrix){
        try{
            this.rows = rows;
            this.cols = cols;
            checkMatrixDimensions(matrix);
            this.matrix = new double[rows][cols];
            for(int i = 0; i < rows; i++){
                double[] row = matrix[i];
                System.arraycopy(row, 0, this.matrix[i], 0, cols);
            }
        } catch (Exception e){
            System.err.println(e.toString());
            System.err.println(e.getMessage());
        }
    }

    private int argMax(int row, int col){
        checkIndexes(row, col);
        double max = Math.abs(this.matrix[row][col]);
        int maxRow = row;
        for (int i = row + 1; i < this.rows; i++){
            if(max < Math.abs(this.matrix[i][col])){
                max = Math.abs(this.matrix[i][col]);
                maxRow = i;
            }
        }

        return maxRow;
    }

    public void backSubstitution(){
        int h = 0;
        int k = 0;
        while (h < rows && k < cols){
            if(matrix[h][k] == 0){
                throw new IllegalArgumentException("Equations without a solution");
            }
            else{
                for(int i = 0; i < h; i++){
                    multiplyAndAddRow(i, h, k);
                }
                k++;
                h++;
            }
        }
    }

    private void checkMatrixDimensions(double[][] matrix){
        if (matrix.length != rows || matrix[0].length != cols){
            throw new IllegalArgumentException("Wrong matrix sizes");
        }
    }

    private void multiplyAndAddRow(int addRow, int mulRow, int colIndex){
        checkRowIndex(addRow);
        checkRowIndex(mulRow);
        checkColIndex(colIndex);
        double f = matrix[addRow][colIndex] / matrix[mulRow][colIndex];
        matrix[addRow][colIndex] = 0;
        for (int j = colIndex + 1; j < cols; j++){
            matrix[addRow][j] = matrix[addRow][j] - matrix[mulRow][j] * f;
        }
    }

    private void multiplyRow(int rowInd, int colInd){
        double pivot = matrix[rowInd][colInd];
        for (int j = 0; j < cols; j++){
            matrix[rowInd][j] = matrix[rowInd][j] / pivot;
        }
    }

    public void print(){
        for(int i = 0; i < rows; i++){
            for(int j = 0; j < cols - 1; j++){
                if(matrix[i][j] >= 0){
                    System.out.print("+" + matrix[i][j] + abc[j]);
                }
                else{
                    System.out.print("" + matrix[i][j] + abc[j]);
                }
            }
            System.out.println("=" + matrix[i][cols-1]);
        }
        System.out.println();
    }

    public void rowEchelonForm(){
        int h = 0;
        int k = 0;
        while (h < rows && k < cols){
            int maxRow = argMax(h, k);
            if(matrix[maxRow][k] == 0){
                k++;
            }
            else{
                swapRows(h, maxRow);
                for(int i = h + 1; i < rows; i++){
                    multiplyAndAddRow(i, h, k);
                }
                multiplyRow(h, k);
                k++;
                h++;
            }
        }
    }

    private void swapRows(int a, int b){
        checkRowIndex(a);
        checkRowIndex(b);
        double[] row = this.matrix[a];
        this.matrix[a] = this.matrix[b];
        this.matrix[b] = row;
    }

    private void checkIndexes(int row, int col){
        checkRowIndex(row);
        checkColIndex(col);
    }

    private void checkRowIndex(int row){
        if (rows <= row){
            throw new IllegalArgumentException("Wrong row index size");
        }
    }

    private void checkColIndex(int col){
        if (cols <= col){
            throw new IllegalArgumentException("Wrong col index size");
        }
    }
}