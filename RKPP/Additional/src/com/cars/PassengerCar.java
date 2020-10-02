package com.cars;

public class PassengerCar extends Car {

    private String bodyType;
    private int countOfDoors;
    private boolean isAutomatic;
    private String color;

    public PassengerCar(String brand, String model, int year, int maxSpeed,String bodyType,int countOfDoors, boolean isAutomatic, String color) {
        super(brand, model, year, maxSpeed);
        this.bodyType = bodyType;
        this.countOfDoors = countOfDoors;
        this.isAutomatic = isAutomatic;
        this.color = color;
    }

    @Override
    public void getInfoCar() {
        System.out.println("Passenger car "+getBrand()+" "+getModel()+" "+getYear()+" "+getMaxSpeed()+" "+getBodyType()+" "+getCountOfDoors()+" "+isAutomatic()+" "+getColor()+" ");
    }

    @Override
    public void changeMaxSpeed(int newSpeed) {
        setMaxSpeed(newSpeed);
    }

    public String getBodyType() {
        return bodyType;
    }

    public void setBodyType(String bodyType) {
        this.bodyType = bodyType;
    }

    public int getCountOfDoors() {
        return countOfDoors;
    }

    public void setCountOfDoors(int countOfDoors) {
        this.countOfDoors = countOfDoors;
    }

    public boolean isAutomatic() {
        return isAutomatic;
    }

    public void setAutomatic(boolean automatic) {
        isAutomatic = automatic;
    }

    public String getColor() {
        return color;
    }

    public void setColor(String color) {
        this.color = color;
    }
}
