package com.company;

import com.cars.*;

public class Main {

    public static void main(String[] args) {
        Bus bus = new Bus(
                "Bus Brand",
                "Bus Model",
                2000,
                80,
                120,
                40,
                "Bus Type");
        FreightCar freightCar = new FreightCar(
                "Freight car Brand",
                "Freight car Model",
                1954,
                300,
                3.5,
                3,
                "Freight car Carcase type");
        PassengerCar passengerCar = new PassengerCar(
                "Passenger car Brand",
                "Passenger car Model",
                2943,
                200,
                "Passenger car body type",
                4,
                true,
                "Green");

        bus.getInfoCar();
        freightCar.getInfoCar();
        passengerCar.getInfoCar();

        bus.changeMaxSpeed(150);
        freightCar.changeMaxSpeed(400);
    }
}
