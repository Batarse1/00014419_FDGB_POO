package com.FDGB.x00014419;

import javax.swing.*;

public class Ammo extends ReusableItem{
    private boolean equipped = false;

    public Ammo(int remainingUses, boolean equipped) {
        super(remainingUses);
        this.equipped = equipped;
    }

    public Ammo(String name, int weight, String description, int remainingUses, boolean equipped) {
        super(name, weight, description, remainingUses);
        this.equipped = equipped;
    }

    public boolean isEquipped() {
        return equipped;
    }

    public void equip(){
        if(equipped==false){
            equipped=true;
            JOptionPane.showMessageDialog(null,"La munición se a equipado");
        }
        else {
            JOptionPane.showMessageDialog(null,"La munición ya se esta ocupando");
        }
    }

    @Override
    public String toString() {
        return "Ammo{" +
                "equipped=" + equipped +
                ", remainingUses=" + remainingUses +
                ", id=" + id +
                ", name='" + name + '\'' +
                ", weight=" + weight +
                ", description='" + description + '\'' +
                '}';
    }
}
