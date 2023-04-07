package math.operation.safe;
public class Increment{

    public static void increment(int i){
        if(Integer.MAX_VALUE == i){
            return i;
        }
        else {
            return i+1;
        }
    }
}