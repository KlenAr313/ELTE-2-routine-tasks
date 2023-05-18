import java.util.*;
import java.io.*;

public class Main {
    public static void main(String[] args) {
        ArrayList<Integer> div = new ArrayList<Integer>(); 
        divisors(64, div);
        System.out.println(div);
    }

    public static void divisors(int szam, ArrayList<Integer> div){
        if (szam < 0){
            throw new IllegalArgumentException();
        }

        for (int i = 1; i < szam; i++){
            if(szam % i == 0){
                div.add(i);
            }
        }
    }
}
/*

public class Main {
    public static void main(String[] args) {
        abc("Teszt Elek");
    }

    private static void abc(String s) throws IOException {
        throw new IOException("Hibás szöveg");
    }
}

*/