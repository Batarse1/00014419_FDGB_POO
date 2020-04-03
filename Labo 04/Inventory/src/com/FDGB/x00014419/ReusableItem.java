package com.FDGB.x00014419;

abstract class ReusableItem extends Item{
    protected int remainingUses = 0;

    public ReusableItem(int remainingUses) {
        this.remainingUses = remainingUses;
    }

    public ReusableItem(String name, int weight, String description, int remainingUses) {
        super(name, weight, description);
        this.remainingUses = remainingUses;
    }

    public void reduceUse(){
        this.remainingUses--;
    }

    public boolean use(){
        if(this.remainingUses>0){
            this.remainingUses--;
            return true;
        }
        else{
            return false;
        }
    }
}