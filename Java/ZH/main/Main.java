package main;

import game.*;
import game.vehicles.*;
import java.io.*;

public class Main{
    public static void main(String[] args){
        Player Daniel = loadPlayerFromFile("Daniel");
        Player Peter = loadPlayerFromFile("Peter");
        Player Richard = loadPlayerFromFile("Richard");
        Player Tamas = loadPlayerFromFile("Tamas");
        Player Zorror  = loadPlayerFromFile("Zorror");

        Car kek = new Car(100, 100);
        Car zud = new Car(120, 100);
        Car piros = new Car(140, 110);
        Car sarga = new Car(160, 120);
        Car fekete = new Car(180, 130);
    }

    public static Player loadPlayerFromFile(String playerName){
        File input = new File("users/" + playerName + ".txt");

        String[] data = null;
        try (BufferedReader bf = new BufferedReader(new FileReader(input))){
            String line = bf.readLine();
            data = line.split(" ");

            int cash = 0;
            try{
                cash = Integer.parseInt(data[1]);
            }
            catch (Exception e){
                cash = 0;
            }

            return new Player(playerName, data[0], cash);
        } catch (IOException e) {
            System.out.println("IO error occured: " + e.getMessage());
        }

        return null;
    }
}