package linear;

public class EquationSolver{
    public static double[] stringsToDoubles(String[] s){
        try{
            double[] out = new double[s.length];
            double d;
            for (int i = 0; i < s.length; i++){
                d = Double.parseDouble(s[i]);
                out[i] = d;
            }

            return out;
        }
        catch (Exception e){
            throw new IllegalArgumentException("We can't parse that.");
        }
    }
}