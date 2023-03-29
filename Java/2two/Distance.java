import static java.lang.System.*;

public class Distance{
    public static void main(String[] args){
        if(args.length < 4){
            out.println(0.0);
        }
        else if (args.length % 2 != 0 ){
            out.println("You fuckin chicken, something is missing");
        }
        else{
            double dis = 0;
            for(int i = 2 ; i < args.length; i++){
                
                dis += Math.sqrt(Math.pow(Integer.parseInt(args[i]) - Integer.parseInt(args[i-2]), 2) + Math.pow(Integer.parseInt(args[i + 1]) - Integer.parseInt(args[i-1]), 2));
                i++;
            }
            console().printf("%f", dis);
        }
    }
}