package com.FDGB.x00014419;

import javax.swing.*;

public class Weapon extends ReusableItem{
    private String type = "\0";
    private double speed = 0.00f;
    private double damage = 0.00f;
    private String wieldType = "\0";
    private int level = 0;

    public Weapon(int remainingUses, String type, double speed, double damage, String wieldType, int level) {
        super(remainingUses);
        this.type = type;
        this.speed = speed;
        this.damage = damage;
        this.wieldType = wieldType;
        this.level = level;
    }

    public Weapon(String name, int weight, String description, int remainingUses, String type, double speed, double damage, String wieldType, int level) {
        super(name, weight, description, remainingUses);
        this.type = type;
        this.speed = speed;
        this.damage = damage;
        this.wieldType = wieldType;
        this.level = level;
    }

    public String getType() {
        return type;
    }

    public double getSpeed() {
        return speed;
    }

    public double getDamage() {
        return damage;
    }

    public String getWieldType() {
        return wieldType;
    }

    public int getLevel() {
        return level;
    }

    public void upgrade(){
        JOptionPane.showMessageDialog(null,"El arma se a mejorado");
    }

    @Override
    public String toString() {
        return "Weapon{" +
                "type='" + type + '\'' +
                ", speed=" + speed +
                ", damage=" + damage +
                ", wieldType='" + wieldType + '\'' +
                ", level=" + level +
                ", remainingUses=" + remainingUses +
                ", id=" + id +
                ", name='" + name + '\'' +
                ", weight=" + weight +
                ", description='" + description + '\'' +
                '}';
    }
}