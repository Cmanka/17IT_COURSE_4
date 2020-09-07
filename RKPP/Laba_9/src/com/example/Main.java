package com.example;
import java.net.*;
import java.io.*;

public class Main {

    public static void main(String[] args) {
        try {

            ServerSocket ChartServer = new ServerSocket(8071);
            System.out.println("init");

            while (true) {
                Socket ChartSoket = ChartServer.accept();
                System.out.println(ChartSoket.getInetAddress().getHostName() + "connected");

                Client server = new Client(ChartSoket);
                server.start();

                if (server.disconnect()) {
                    ChartSoket.getInetAddress().getAddress();
                    ChartSoket.getInetAddress().getHostName();
                    Client server1 = new Client(ChartSoket);
                    server1.start();
                }

            }//while
        } catch (IOException w) {
            System.err.println(w);
        }
    }
}
