package com.example;

import java.net.*;
import java.io.*;

class Client extends Thread {
    private PrintStream ps;
    private BufferedReader br;
    private InetAddress ia;

    public Client(Socket s) throws IOException, SocketException {
        ps = new PrintStream(s.getOutputStream());
        br = new BufferedReader(new InputStreamReader(s.getInputStream()));
        ia = s.getInetAddress();


    }

    public synchronized void run() {
        int i = 0;
        String str;


        try {
            while ((str = br.readLine()) != null) {
                if (str.equals(ia))
                    ps.println("Is given" + ++i);

                System.out.println("Disconnected Client" + i + "with" + ia.getHostName());
            }
        } catch (IOException r) {
            System.out.println("Disconnect");
        } finally {
            disconnect();
        }
    }


    public boolean disconnect() {
        try {
            System.out.println(ia.getHostName() + "disconnected");
            ps.close();
            br.close();
        } catch (IOException f) {
            f.printStackTrace();
        } finally {
            this.interrupt();
        }

        return true;
    }

}