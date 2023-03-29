package famous.sequence;

public class TriangularNumbers{
    public static int getTriangularNumber(int a){
        int b = (a * (a+1))/2;
        return b <= 0 ? 0 : b;
    }
}