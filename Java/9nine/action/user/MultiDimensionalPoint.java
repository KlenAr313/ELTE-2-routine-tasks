package action.user;

public class MultiDimensionalPoint implements action.Undoable, action.Scalable{
    private int[] coordinates;
    private int[] lastCoordinates;

    public MultiDimensionalPoint(int... nums){

    }

    public int get(int num){
        return coordinates[num];
    }

    public void set(int dim, int val){
        coordinates[dim] = val;
    }
    
    public void undoLast(){
        
    }

    public void scale(int num){

    }
}