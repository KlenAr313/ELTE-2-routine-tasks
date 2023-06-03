package game.vehicles;

import game.*;
import game.utils.*;

public class Car extends Vehicle implements Comparable{
    private final int maxSpeed;
    private final int cost;

    public int getCost(){
        return this.cost;
    }

    private Player owner;

    public Player getOwner(){
        return owner;
    }

    public void setOwner(Player owner){
        this.owner = owner;
    }

    public Car(int maxSpeed, int cost){
        super(); 
        this.maxSpeed = maxSpeed;
        this.cost = cost;
    }

    @Override
    public void accelerate(double amount) throws VehicleException{
        if (super.getCurrentSpeed() + amount <= maxSpeed){
            super.accelerateCurrentSpeed(amount);
        }
        else{}
    }

    @Override
    public int compareTo(Object car){
        return 1;
    }

    public int compareTo(Car car){
        return 1;
    }

    @Override
    public String toString(){
        return "id: " + this.id + 
            "\nMaxSpeed: " + this.maxSpeed + 
            "\nCost: " + this.cost;
    }
}