import linear.algebra.*;

public class Main{
    public static void main(String[] args){
        double[][] matrix1 = new double[][] {
            {2.0, 3.0, 5.0, 8.0},
            {1.0, 2.0, 3.0, 5.0},
            {4.0, 6.0, 8.0, 12.0} };

        double[][] matrix2 = new double[][] {
            { 1.0, 3.0,  1.0,  9.0 },
            { 1.0, 1.0, -1.0,  1.0 },
            { 3.0, 11.0, 5.0, 35.0 } };

        double[][] rowEchelonForm1 = new double[][] {
            { 1.0, 1.5, 2.0, 3.0 },
            { 0.0, 1.0, 2.0, 4.0 },
            { 0.0, 0.0, 1.0, 2.0 } };

        double[][] matrix1AfterBackSubstitution = new double[][] {
            { 1.0, 0.0, 0.0, -1.0 },
            { 0.0, 1.0, 0.0, 0.0  },
            { 0.0, 0.0, 1.0, 2.0  } };

        GaussianElimination ge = new GaussianElimination(3, 4, matrix1);
        ge.rowEchelonForm();

        
        System.out.printf("=%f", 2.0);

        System.out.printf("+%f%c", 3.4545454, 'p');
    }
}