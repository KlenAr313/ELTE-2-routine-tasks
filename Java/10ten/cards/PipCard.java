package cards;

public class PipCard extends Card{
    private int number;

    public PipCard(int number, Suit suit){
        super(suit);
        if(number > 10 || number < 1) throw new IllegalArgumentException("Number must be between 1 and 10");
        this.number = number;
    }

    @Override
    public String toString(){
        if(number != 1){
            return super.toString() + "(" + number + ")";
        }
        return "ACE of " + super.toString();
    }

}
