package com.FDGB.x00014419;

import javax.swing.*;

public class Elixir extends HealthItem{
    private int amount = 0;
    private int time = 0;

    public Elixir(int reuseTime, String level, String type, int amount, int time) {
        super(reuseTime, level, type);
        this.amount = amount;
        this.time = time;
    }

    public Elixir(String name, int weight, String description, int reuseTime, String level, String type, int amount, int time) {
        super(name, weight, description, reuseTime, level, type);
        this.amount = amount;
        this.time = time;
    }

    public int getAmount() {
        return amount;
    }

    public int getTime() {
        return time;
    }

    @Override
    public void drink(){
        JOptionPane.showMessageDialog(null,"Se a tomado el Elixir");
        amount=0;
        while(time>0){
            if(time%5==0){
                JOptionPane.showMessageDialog(null,"Se a regenerado vida");
            }
        }
    }

    @Override
    public String toString() {
        return "Elixir{" +
                "amount=" + amount +
                ", time=" + time +
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