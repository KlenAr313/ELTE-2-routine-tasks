import java.util.*;

public class CharacterStatistics{
    HashMap<Character, Integer> stat;

    public CharacterStatistics(String s){
        char[] dude = s.toCharArray();
        stat = new HashMap<>();

        for(int i = 0; i < dude.length; i++){
            if(stat.containsKey(dude[i])){
                stat.put(dude[i], stat.get(dude[i]) + 1);
            }
            else {
                stat.put(dude[i], 1);
            }
        }
    }
}