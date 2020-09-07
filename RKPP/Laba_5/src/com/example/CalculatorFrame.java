package com.example;

import javax.swing.*;
import java.awt.*;

public class CalculatorFrame extends JFrame {
    public CalculatorFrame() {
        setTitle("Calculator");
        CalculatorPanel panel = new CalculatorPanel();
        panel.setPreferredSize(new Dimension(300,300));
        setResizable(false);
        add(panel);
        pack();
    }
}
