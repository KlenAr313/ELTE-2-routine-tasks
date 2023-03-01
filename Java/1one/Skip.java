public class Skip{
    public static void main(String[] args){
        if(args.length == 2){
            System.out.println("asd");

            int egy = Integer.parseInt( args[0]);
            int ketto = Integer.parseInt( args[1]);

            // for(int i = egy; i <= ketto; i++)
            //     System.out.println(i/2.0);
            System.out.println(egy+ketto);
            System.out.println(egy-ketto);
            System.out.println(egy*ketto);
            if(ketto != 0)
                System.out.println((double)egy/ketto);

            System.out.println(recursio(egy));
        }

        // String arg1;
        // if (args.length > 0){
        //     arg1 = args[0];
        //     System.out.println(arg1);
        // }
        // else {
        //     System.out.println("NOP");
        // }

        // System.console().printf("%d\n",args.length);
        // String input = System.console().readLine();
        // System.out.println(input);
    }

    public static int recursio(int n){
        int res = 1;
        for (int i = 1; i <= n; i++)
            res *= i;
        return res;
    }
}