package com.example;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class CalculatorPanel extends JPanel {
    private JButton display;
    private JPanel panel;
    private Double result;
    private String lastCommand;
    private Boolean start;
    private Character[] calculatorElements = new Character[]{'7', '8', '9', '/', '4', '5', '6', '*', '1', '2', '3', '-', '0', '.', '=', '+'};
    private Character[] example = new Character[]{'1','2','3'};


    public CalculatorPanel() {
        setLayout(new BorderLayout());

        result = new Double(0);
        lastCommand = "=";
        start = true;

        addResultButton();

        ActionListener insert = new InsertAction();
        ActionListener command = new CommandAction();

        panel = new JPanel();
        panel.setLayout(new GridLayout(4, 4));
        for (int i = 0; i < calculatorElements.length; i++) {
            if (calculatorElements[i] >= '1' && calculatorElements[i] <= '9' || calculatorElements[i].equals('.')) {
                addButton(calculatorElements[i].toString(), insert);
            } else {
                addButton(calculatorElements[i].toString(), command);
            }
        }

        calculatorElements = null;
        calculatorElements = example;
        add(panel, BorderLayout.CENTER);
    }

    private void addResultButton() {
        display = new JButton("0");
        display.setEnabled(false);
        display.setPreferredSize(new Dimension(50, 50));
        display.setFont(new Font("TimesRoman", Font.CENTER_BASELINE, 36));
        display.setHorizontalAlignment(SwingConstants.RIGHT);
        add(display, BorderLayout.NORTH);
    }

    private void addButton(String label, ActionListener listener) {
        JButton button = new JButton(label);
        button.addActionListener(listener);
        panel.add(button);
    }

    private class InsertAction implements ActionListener {
        public void actionPerformed(ActionEvent event) {
            String input = event.getActionCommand();
            if (start) {
                display.setText("");
                start = false;
            }
            display.setText(display.getText() + input);
        }
    }

    private class CommandAction implements ActionListener {
        public void actionPerformed(ActionEvent event) {
            String command = event.getActionCommand();
            if (start) {
                if (command.equals("-")) {
                    display.setText(command);
                    start = false;
                } else lastCommand = command;
            } else {
                calculate(Double.parseDouble(display.getText()));
                lastCommand = command;
                start = true;
            }
        }
    }

    public void calculate(Double x) {
        System.out.println(calculatorElements);
        switch (lastCommand) {
            case "+": {
                result += x;
                break;
            }
            case "-": {
                result -= x;
                break;
            }
            case "*": {
                result *= x;
                break;
            }
            case "/": {
                result /= x;
                break;
            }
            case "=": {
                result = x;
                break;
            }
        }
        display.setText("" + result);
    }

}
