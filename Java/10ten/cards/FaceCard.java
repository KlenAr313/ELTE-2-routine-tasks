package cards;

public class FaceCard extends Card{
    private Face face;

    public FaceCard(Face face, Suit suit){
        super(suit);
        this.face = face;
    }

    @Override
    public String toString(){
        return face.toString() + " of " + super.toString();
    }
}