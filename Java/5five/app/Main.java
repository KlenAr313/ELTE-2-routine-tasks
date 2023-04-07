package app;

import static java.lang.System.*;

import unique.*;

public class Main {
    public static void main(String[] args) {
        Printer a = new Printer();
        Printer b = new Printer();

        a.print("a");
        a.print("a");
        a.print("b");
        out.println(a);
        b.print("b");
        b.print("b");

        
    }
}
