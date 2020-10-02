package com.cars;

public class Bus extends Car {

    private int countOfPassengers;
    private int countOfSitPassengers;
    private String busType;

    public Bus(String brand, String model, int year, int maxSpeed,int countOfPassengers,int countOfSitPassengers,String busType) {
        super(brand, model, year, maxSpeed);
        this.countOfPassengers = countOfPassengers;
        this.countOfSitPassengers = countOfSitPassengers;
        this.busType = busType;
    }

    @Override
    public void getInfoCar() {
        System.out.println("Bus "+getBrand()+" "+getModel()+" "+getYear()+" "+getMaxSpeed()+" "+getCountOfPassengers()+" "+getCountOfSitPassengers()+" "+getBusType());
    }

    @Override
    public void changeMaxSpeed(int newSpeed) {
        if(newSpeed <= 100)
            setMaxSpeed(newSpeed);
        else
            System.out.println("This is a bus, max speed cannot be more 100");
    }

    public int getCountOfPassengers() {
        return countOfPassengers;
    }

    public void setCountOfPassengers(int countOfPassengers) {
        this.countOfPassengers = countOfPassengers;
    }

    public int getCountOfSitPassengers() {
        return countOfSitPassengers;
    }

    public void setCountOfSitPassengers(int countOfSitPassengers) {
        this.countOfSitPassengers = countOfSitPassengers;
    }

    public String getBusType() {
        return busType;
    }

    public void setBusType(String busType) {
        this.busType = busType;
    }
}
