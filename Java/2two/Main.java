import static java.lang.System.*;

public class Main{
    public static void main(String[] args){
        Point p = new Point(1,1);
        Circle c = new Circle(p, 4);

        out.println(c.getArea());
    }
}