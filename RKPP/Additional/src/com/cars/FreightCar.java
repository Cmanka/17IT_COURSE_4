package com.cars;

public class FreightCar extends Car {

    private double maxCapacity;
    private int countOfAxles;
    private String carcaseType;

    public FreightCar(String brand, String model, int year, int maxSpeed,double maxCapacity,int countOfAxles, String carcaseType) {
        super(brand, model, year, maxSpeed);
        this.maxCapacity = maxCapacity;
        this.countOfAxles = countOfAxles;
        this.carcaseType = carcaseType;
    }

    @Override
    public void getInfoCar() {
        System.out.println("Fraihgt car "+getBrand()+" "+getModel()+" "+getYear()+" "+getMaxSpeed()+" "+getMaxCapacity()+" "+getCountOfAxles()+" "+getCarcaseType());
    }

    @Override
    public void changeMaxSpeed(int newSpeed) {
        setMaxSpeed(newSpeed);
    }

    public double getMaxCapacity() {
        return maxCapacity;
    }

    public void setMaxCapacity(double maxCapacity) {
        this.maxCapacity = maxCapacity;
    }

    public int getCountOfAxles() {
        return countOfAxles;
    }

    public void setCountOfAxles(int countOfAxles) {
        this.countOfAxles = countOfAxles;
    }

    public String getCarcaseType() {
        return carcaseType;
    }

    public void setCarcaseType(String carcaseType) {
        this.carcaseType = carcaseType;
    }
}
