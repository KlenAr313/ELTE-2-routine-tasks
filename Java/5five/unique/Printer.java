package unique;
import static java.lang.System.*;

public class Printer{

    String c = "";

    public void print (String s){
        if (!s.equals(c)){
            out.println(s);
            c = s;
        }
    }

    @Override
    public String toString(){
        return c;
    }
}