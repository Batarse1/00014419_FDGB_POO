package com.FDGB.x00014419;

import javax.swing.*;

public class Potion extends HealthItem{
    private int amount = 0;

    public Potion(int reuseTime, String level, String type, int amount) {
        super(reuseTime, level, type);
        this.amount = amount;
    }

    public Potion(String name, int weight, String description, int reuseTime, String level, String type, int amount) {
        super(name, weight, description, reuseTime, level, type);
        this.amount = amount;
    }

    public int getAmount() {
        return amount;
    }

    @Override
    public void drink(){
        JOptionPane.showMessageDialog(null,"Se a tomado la pocion");
        amount = 0;
    }

    @Override
    public String toString() {
        return "Potion{" +
                "amount=" + amount +
                ", reuseTime=" + reuseTime +
                ", level='" + level + '\'' +
                ", type='" + type + '\'' +
                ", id=" + id +
                ", name='" + name + '\'' +
                ", weight=" + weight +
                ", description='" + description + '\'' +
                '}';
    }
}