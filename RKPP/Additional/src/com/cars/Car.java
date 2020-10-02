package com.cars;

public abstract class Car {

    private String brand;
    private String model;
    private int year;
    private int maxSpeed;

    public Car(String brand, String model, int year,int maxSpeed){
        this.brand = brand;
        this.model = model;
        this.year = year;
        this.maxSpeed = maxSpeed;
    }

    public abstract void getInfoCar();
    public abstract void changeMaxSpeed(int newSpeed);

    public String getBrand() {
        return brand;
    }

    public void setBrand(String brand) {
        this.brand = brand;
    }

    public String getModel() {
        return model;
    }

    public void setModel(String model) {
        this.model = model;
    }

    public int getYear() {
        return year;
    }

    public void setYear(int year) {
        this.year = year;
    }

    public int getMaxSpeed() {
        return maxSpeed;
    }

    public void setMaxSpeed(int maxSpeed) {
        this.maxSpeed = maxSpeed;
    }
}
