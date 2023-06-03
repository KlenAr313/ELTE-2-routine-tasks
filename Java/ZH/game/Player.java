package game;
import game.vehicles.*;
import java.util.*;


public class Player{
    private String name;
    private String ip;
    private int money;

    public int getMoney(){
        return money;
    }

    private ArrayList<Vehicle> cars;

    public Player(String name, String ip, int money){
        if(name != null && ip != null && !ip.contains(" ") 
            && !ip.contains("\n") && !ip.contains("\t") 
            && !ip.contains("\r") && money >= 0){
            this.name = name;
            this.ip = ip;
            this.money = money;
            cars = new ArrayList<>();
        }
        else{
            throw new IllegalArgumentException();
        }

        
    }

    public void buyCar(Car car){
        cars.add(car);
    }

    public ArrayList<Vehicle> getSortedCars(){
        return this.cars;
    }

    @Override
    public String toString(){
        return "Name";
    }

    public boolean equals(Player p){
        return true;
    }
}