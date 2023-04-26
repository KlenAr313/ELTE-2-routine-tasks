import java.io.*;

public class Main{
    public static void main(String[] args){
        try{
            solv("inp.txt");
        }
        catch(FileNotFoundException e){
            System.out.println("ÁÁÁÁÁÁÁÁÁÁÁÁÁÁÁŰÁÁÁÁÁÁÁÁÁÁÁÁÁÁÁÁÁÁÁÁÁÁ");
        }
    }

    static void solv (String name) throws FileNotFoundException{
        try (BufferedReader reader = new BufferedReader(new FileReader(name)); PrintWriter writer = new PrintWriter("output.txt")){
            int sum = 0;
            String line;
            String[] numbers;
            while((line = reader.readLine()) != null){
                sum = 0;
                numbers = line.split(" ");
                for(int i = 0; i < numbers.length; i++)
                {
                    sum += Integer.parseInt(numbers[i]);
                }
                reader.out.println(sum);
            }
        }
        catch (FileNotFoundException e){
            throw e;
        }
        catch (IOException e) {
            System.err.println("Valami rossz");
        }
    }
}