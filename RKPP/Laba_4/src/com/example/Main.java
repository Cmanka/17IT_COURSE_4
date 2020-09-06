package com.example;

import com.example.patterns.DecoratorTest;
import com.example.patterns.IteratorTest;
import com.example.patterns.Singleton;

public class Main {

    public static void main(String[] args) {
        Singleton instance = Singleton.getInstance();
        instance.check();
        DecoratorTest.main(args);
        IteratorTest.main(args);
    }
}
