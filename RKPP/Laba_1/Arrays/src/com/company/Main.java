package com.company;

import java.util.Scanner;

public class Main {


    static void FirstTask() {
        Scanner in = new Scanner(System.in);
        float x;
        System.out.println("Enter x (real number)");
        x = in.nextFloat();
        int n;
        System.out.println("Enter n (array size)");
        n = in.nextInt();
        float[] arr = new float[n];

        for (int i = 0; i < arr.length; i++) {
            arr[i] = Math.round((Math.random() * 100) - 1);
            System.out.print(arr[i] + " ");
        }
        System.out.println();

        float midValue;
        float closestValue = arr.length > 1 ? (arr[0] + arr[1]) / 2 : 0;
        float closesValues[] = new float[2];
        for (int i = 0; i < arr.length; i++) {
            for (int j = 0; j < arr.length; j++) {
                if (i == j)
                    continue;
                midValue = (arr[i] + arr[j]) / 2;
                if (Math.abs(midValue - x) < closestValue) {
                    closestValue = Math.abs(midValue - x);
                    closesValues[0] = arr[i];
                    closesValues[1] = arr[j];
                }
            }
        }
        System.out.println("Closest values to " + x + " " + closesValues[0] + " + " + closesValues[1] + " = " + (closesValues[0] + closesValues[1]) / 2);
    }

    static void SecondTask() {
        Scanner in = new Scanner(System.in);
        int rows = 0, columns = 0;
        System.out.println("Enter rows ");
        rows = in.nextInt();
        System.out.println("Enter columns ");
        columns = in.nextInt();
        int[][] arr = new int[rows][columns];

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < columns; j++) {
                arr[i][j] = (int) Math.round((Math.random() * 100) - 50);
                System.out.print(arr[i][j] + "\t");
            }
            System.out.println();
        }
        int maxPositive = -100;
        int minNegative = 100;
        MyValue max = new MyValue();
        MyValue min = new MyValue();
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < columns; j++) {
                if (arr[i][j] > 0) {
                    if(maxPositive < arr[i][j]){
                        maxPositive = arr[i][j];
                        max.value = maxPositive;
                        max.row = i;
                        max.column = j;
                    }

                } else {
                    if(minNegative > arr[i][j]){
                        minNegative = arr[i][j];
                        min.value = minNegative;
                        min.row = i;
                        min.column = j;
                    }
                }
            }
        }
        int tmp = arr[max.row][max.column];
        arr[max.row][max.column] = arr[min.row][min.column];
        arr[min.row][min.column] = tmp;
        System.out.println("Max value:"+max.value+"\nMin value:"+min.value);
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < columns; j++) {
                System.out.print(arr[i][j] + "\t");
            }
            System.out.println();
        }
    }

    public static void main(String[] args) {
        FirstTask();
        SecondTask();
    }
}
