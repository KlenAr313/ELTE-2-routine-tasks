import static java.lang.System.*;

public class Main{
    public static void main(String[] args){
        Point a = new Point(Double.parseDouble(args[0]), Double.parseDouble(args[1]));
        Point b = new Point(Double.parseDouble(args[2]), Double.parseDouble(args[3]));

        Point c = a.add(b);

        out.println(c.x + " " + c.y);
    }
}