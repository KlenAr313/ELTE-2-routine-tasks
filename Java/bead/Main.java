import linear.*;
import linear.algebra.*;

public class Main{
    public static void main(String[] args){
        try{
            double[][] matrix = new double[args.length][];
            for(int i = 0; i < args.length; i++){
                String[] line = args[i].split(",");
                double[] row = EquationSolver.stringsToDoubles(line);
                matrix[i] = row;
            }

            GaussianElimination ge = new GaussianElimination(matrix.length, matrix[0].length, matrix);
            ge.print();
            ge.rowEchelonForm();
            ge.print();
            ge.backSubstitution();
            ge.print();
        }catch (Exception e){
            System.err.println(e.toString());
            System.err.println(e.getMessage());
        }
        
    }
}