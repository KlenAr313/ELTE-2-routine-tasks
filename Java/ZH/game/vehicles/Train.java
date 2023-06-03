package game.vehicles;

import game.utils.*;

public class Train extends Vehicle{
    public Train(){}

    @Override
    public void accelerate(double amount) throws VehicleException{
        if(amount < 0){
            super.accelerateCurrentSpeed(amount / 10);
        }
        else{
            super.accelerateCurrentSpeed(amount);
        }
    }
}