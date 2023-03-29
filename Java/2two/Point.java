public class Point{
    double x;
    double y;

    public Point(double x, double y){
        this.x = x;
        this.y = y;
    }

    public void move (double x, double y){
        this.x += x;
        this.y += y;
    }

    public void mirror(Point p){
        x = x - p.x - p.x;
        y = y - p.y - p.x;
    }

    public double Distane(Point p)
    {
        return  Math.sqrt(Math.pow( x - p.x, 2 ) + Math.pow( y - p.y, 2 ));
    }
}