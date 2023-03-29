public class Point{
    final double x;
    final double y;

    public Point(double x, double y){
        this.x = x;
        this.y = y;
    }

    public Point(){
        this(0, 0);
    }

    public Point add(Point p){
        if (p == null){
            throw new IllegalArgumentException("Ez egy null te csirke");
        }
        double a = this.x + p.x;
        double b = this.y + p.y;
        return new Point(a,b);
    }
}