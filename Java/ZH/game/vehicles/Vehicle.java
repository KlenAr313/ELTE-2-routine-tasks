package game.vehicles;

import game.utils.*;

public abstract class Vehicle{
    private static int currentId = 0;
    protected final int id;
    private double currentSpeed;

    public double getCurrentSpeed(){
        return currentSpeed;
    }

    protected Vehicle(){
        this.id = currentId;
        currentId++;
    }

    public abstract void accelerate(double amount) throws VehicleException;

    protected final void accelerateCurrentSpeed(double amount) throws VehicleException{
        if(currentSpeed < amount){
            throw new VehicleException();
        }
        else{
            this.currentSpeed += amount;
        }
    }
}