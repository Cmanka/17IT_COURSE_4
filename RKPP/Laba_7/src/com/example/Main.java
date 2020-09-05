package com.example;

import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.util.Stack;

public class Main {

    static void printStacks(Stack<Integer> fStack, Stack<Integer> sStack) {
        System.out.println(fStack);
        System.out.println(sStack);
        System.out.println();
    }

    static void swapStacks(Stack<Integer> fStack, Stack<Integer> sStack) {
        Stack<Integer> tmpStack = new Stack<Integer>();
        tmpStack.addAll(fStack);
        fStack.clear();
        fStack.addAll(sStack);
        sStack.clear();
        sStack.addAll(tmpStack);
    }

    static void readStream(Stack<Integer> stack, String filePath) {
        try (FileInputStream fin = new FileInputStream(filePath)) {
            int i = -1;
            while ((i = fin.read()) != -1) {
                stack.push(i - '0');
            }
        } catch (IOException ex) {

            System.out.println(ex.getMessage());
        }
    }

    static void writeStream(Stack<Integer> stack, String filePath) {
        String str = "";
        try (FileOutputStream fos = new FileOutputStream(filePath)) {
            while (!stack.isEmpty()) {
                str+=stack.pop();
            }
            fos.write(str.getBytes());
        } catch (IOException ex) {

            System.out.println(ex.getMessage());
        }
    }

    static void FirstTask() {
        Stack<Integer> fStack = new Stack<Integer>();
        Stack<Integer> sStack = new Stack<Integer>();

        for (int i = 0; i < 10; i++) {
            fStack.push(i * 3);
            sStack.push(i * 2 + 1);
        }

        printStacks(fStack, sStack);

        swapStacks(fStack, sStack);

        printStacks(fStack, sStack);
    }

    static void SecondTask() {

        Stack<Integer> fStack = new Stack<Integer>();
        Stack<Integer> sStack = new Stack<Integer>();

        readStream(fStack, "fStack.txt");
        readStream(sStack, "sStack.txt");

        writeStream(fStack,"fStack.txt");
        writeStream(sStack,"sStack.txt");
    }

    public static void main(String[] args) {
        //FirstTask();
        SecondTask();
    }
}
