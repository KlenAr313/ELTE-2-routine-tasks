package cards;

public abstract class Card{
    private Suit suit;

    protected Card(Suit suit){
        if (suit == null) throw new IllegalArgumentException("suit mustn't be null");
        this.suit = suit;
    }

    public Suit getSuit(){
        return this.suit;
    }

    @Override
    public String toString(){
        return this.suit.toString();
    }
}
