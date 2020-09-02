package com.example;

import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

public class MyGUI {
    public JFrame window = new JFrame("Calculator");
    public JTextField input = new JTextField();

    public MyGUI()
    {
        window.setSize(300, 300);
        window.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        window.setLayout(null);
        window.setResizable(false);
        window.setLocationRelativeTo(null);

        enterField();

        window.setVisible(true);
    }

    private void enterField(){
        input.setFont(new Font("Calibre", Font.CENTER_BASELINE, 24));
        input.setBounds(20, 10, 260, 30);
        input.setBackground(Color.white);
        input.setHorizontalAlignment(JTextField.RIGHT);

        window.add(input);
    }
}
