package com.example;

import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.Dimension;
import java.awt.EventQueue;
import java.awt.Graphics;
import java.awt.Graphics2D;
import java.awt.GridBagConstraints;
import java.awt.GridBagLayout;
import java.awt.RenderingHints;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.*;
import javax.swing.event.ChangeEvent;
import javax.swing.event.ChangeListener;

public class Main {

    public static void main(String[] args) {
        new Main();
    }

    public Main() {
        EventQueue.invokeLater(new Runnable() {
            @Override
            public void run() {
                JFrame frame = new JFrame("Variant8");
                frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
                frame.add(new ControlPane());
                frame.pack();
                frame.setLocationRelativeTo(null);
                frame.setResizable(false);
                frame.setVisible(true);
            }
        });
    }

    public class ControlPane extends JPanel {

        private JButton speedPlus;
        private JButton speedMinus;

        private BallPitPane ballPitPane;

        public ControlPane() {
            setLayout(new BorderLayout());
            ballPitPane = new BallPitPane();
            add(ballPitPane);

            JPanel controls = new JPanel(new GridBagLayout());
            GridBagConstraints gbc = new GridBagConstraints();
            gbc.gridx = 0;
            gbc.gridy = 0;

            speedPlus = new JButton("Добавить скорость");
            speedMinus = new JButton("Уменьшить скорсоть");

            gbc.fill = GridBagConstraints.HORIZONTAL;
            gbc.gridy++;
            controls.add(speedPlus,gbc);
            gbc.gridy++;
            controls.add(speedMinus,gbc);
            add(controls, BorderLayout.SOUTH);


            speedPlus.addActionListener(new ActionListener() {
                @Override
                public void actionPerformed(ActionEvent actionEvent) {
                    int currentSpeed = ballPitPane.getSpeed()+2;
                    System.out.println(currentSpeed);
                    ballPitPane.setSpeed(currentSpeed);
                }
            });
            speedMinus.addActionListener(new ActionListener() {
                @Override
                public void actionPerformed(ActionEvent actionEvent) {
                    int currentSpeed = ballPitPane.getSpeed()-2;
                    System.out.println(currentSpeed);
                    if(currentSpeed<=0){
                        ballPitPane.setSpeed(0);
                    }
                    else{
                        ballPitPane.setSpeed(currentSpeed);
                    }
                }
            });
        }

    }

    public class BallPitPane extends JPanel {

        private Ball ball;
        private int speed;

        public BallPitPane() {
            ball = new Ball(Color.BLACK, 20, 35, 20);
            setSpeed(2);

            Timer timer = new Timer(40, new ActionListener() {
                @Override
                public void actionPerformed(ActionEvent e) {
                    ball.update(getWidth(),speed);
                    repaint();
                }
            });
            timer.start();
        }

        public void setSpeed(int speed) {
            this.speed = speed;
        }
        public int getSpeed(){
            return speed;
        }
        @Override
        public Dimension getPreferredSize() {
            return new Dimension(150, 100);
        }

        @Override
        protected void paintComponent(Graphics g) {
            super.paintComponent(g);
            Graphics2D g2d = (Graphics2D) g.create();
            g2d.setRenderingHint(RenderingHints.KEY_ALPHA_INTERPOLATION, RenderingHints.VALUE_ALPHA_INTERPOLATION_QUALITY);
            g2d.setRenderingHint(RenderingHints.KEY_ANTIALIASING, RenderingHints.VALUE_ANTIALIAS_ON);
            g2d.setRenderingHint(RenderingHints.KEY_COLOR_RENDERING, RenderingHints.VALUE_COLOR_RENDER_QUALITY);
            g2d.setRenderingHint(RenderingHints.KEY_DITHERING, RenderingHints.VALUE_DITHER_ENABLE);
            g2d.setRenderingHint(RenderingHints.KEY_FRACTIONALMETRICS, RenderingHints.VALUE_FRACTIONALMETRICS_ON);
            g2d.setRenderingHint(RenderingHints.KEY_INTERPOLATION, RenderingHints.VALUE_INTERPOLATION_BILINEAR);
            g2d.setRenderingHint(RenderingHints.KEY_RENDERING, RenderingHints.VALUE_RENDER_QUALITY);
            g2d.setRenderingHint(RenderingHints.KEY_STROKE_CONTROL, RenderingHints.VALUE_STROKE_PURE);
            ball.paint(g2d);
            g2d.dispose();
        }

        public class Ball {

            private Color color;
            private int x;
            private int y;
            private int radius;
            private int delta;

            public Ball(Color color, int x, int y, int radius) {
                this.color = color;
                this.x = x;
                this.y = y;
                this.radius = radius;
                delta = Math.random() > 0.5 ? 1 : -1;
            }

            public void update(int width, int speed) {
                x += speed * delta;
                if (x + radius >= width) {
                    x = width - radius;
                    delta *= -1;
                } else if (x < 0) {
                    x = 0;
                    delta *= -1;
                }
            }

            public void paint(Graphics g) {
                g.setColor(color);
                g.fillOval(x, y, radius, radius);
            }

        }

    }
}
