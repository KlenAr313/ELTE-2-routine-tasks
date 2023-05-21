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
        double max = Math.abs(this.matrix[row + 1][col]);
        int maxRow = row + 1;
        for (int i = row + 2; i < this.cols; i++){
            if(max < Math.abs(this.matrix[i][col])){
                max = Math.abs(this.matrix[i][col]);
                maxRow = i;
            }
        }

        return maxRow;
    }

    public void backSubstitution(){
        System.out.println("TODO");
    }

    private void checkMatrixDimensions(double[][] matrix){
        if (matrix.length != rows || matrix[0].length != cols){
            throw new IllegalArgumentException("Wrong matrix sizes");
        }
    }

    private void multiplyAndAddRow(int a, int b, int c){
        System.out.println("TODO");
    }

    private void multiplyRow(int a, int b){
        System.out.println("TODO");
    }

    public void print(){
        System.out.println("TODO");
    }

    public void rowEchelonForm(){
        System.out.println("TODO");
    }

    private void swapRows(int a, int b){
        System.out.println("TODO");
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