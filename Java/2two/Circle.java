public class Circle{
    Point center;
    double r;

    public Circle(Point center, double r){
        this.center = center;
        this.r = r;
    }

    public double getArea(){
        return r*r*Math.PI;
    }

    public void enlarge(double f){
        r *= f;
    }
}