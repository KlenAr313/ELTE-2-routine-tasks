package cards;
import java.util.*;

public class Deck{
    private final ArrayList<Card> list = new ArrayList<>();

    public boolean isEmpty()  {
         return list.isEmpty();
    }

    public Card draw() {
        return list.remove(0);
    }

    public static Deck makeFrenchDeck(){
        Deck deck = new Deck();

        for(Suit suit : Suit.values()){
            for(int i = 1; i <= 10; i++){
                deck.list.add(new PipCard(i, suit));
            }

            for(Face face : Face.values()){
                if(face != Face.CAVALIER){
                    deck.list.add(new FaceCard(face, suit));
                }
            }
        }
        return deck;
    }
}