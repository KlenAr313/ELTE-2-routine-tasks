public class Complex{
    double re;
    double im;

    public Complex(double re, double im){
        this.re = re;
        this.im = im;
    }

    public double abs(){
        return Math.sqrt(Math.pow(re, 2) + Math.pow(im, 2));
    }

    public void add(Complex c){
        re += c.re;
        im += c.im;
    }

    public void sub(Complex c){
        re -= c.re;
        im -= c.im;
    }

    public void mul(Complex c){
        double oldre = re;
        re = re * c.re - im * c.im;
        im = oldre * c.im + c.re * im;
    }

    public String toString(){
        return re + " + " + im + "i";
    }
}