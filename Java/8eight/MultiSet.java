import java.util.*;

public class MultiSet<E> {
    public final HashMap<E,Integer> elements;
    
    public MultiSet(E[] elements){
        this.elements = new HashMap<>();
        for(E element : elements){
            add(element);
        }
    }

    private MultiSet(){
        elements = new HashMap<>();
    }

    public void add(E element){
        if(this.elements.containsKey(element)){
            this.elements.put(element, this.elements.get(element) + 1);
        }
        else{
            this.elements.put(element, 0);
        }
    }

    public int getCount(E element){
        if(this.elements.containsKey(element)){
            return this.elements.get(element);
        }
        return 0;
    }

    public MultiSet<E> intersect(MultiSet<E> a){
        MultiSet<E> section = new MultiSet<>();
        for (E element : a.elements.keySet()){
            if(this.elements.containsKey(element)){
                if(this.elements.get(element) > a.elements.get(element)){
                    section.elements.put(element, a.elements.get(element));
                }
                else{
                    section.elements.put(element, this.elements.get(element));
                }
            }
        }
        return section;
    }

}